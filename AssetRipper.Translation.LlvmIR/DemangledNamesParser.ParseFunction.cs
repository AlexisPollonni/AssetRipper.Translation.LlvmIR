using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using AssetRipper.Translation.LlvmIR.Extensions;

namespace AssetRipper.Translation.LlvmIR;

public partial class DemangledNamesParser
{
	public static IParseTree ParseFunction(string input)
	{
		ICharStream stream = CharStreams.fromString(input);
		ITokenSource lexer = new DemangledNamesLexer(stream, TextWriter.Null, TextWriter.Null);
		ITokenStream tokens = new CommonTokenStream(lexer);
		DemangledNamesParser parser = new(tokens, TextWriter.Null, TextWriter.Null);
		return parser.function();
	}

	/// <summary>
	/// Returns true if the given demangled name is a known unstructured LLVM pseudo-name
	/// that cannot be expressed as a C++ function signature (e.g. TLS wrapper stubs).
	/// </summary>
	private static bool IsKnownUnparseable(string input)
	{
		// e.g. "thread-local wrapper routine for __llvm_libc_20_1_2_::internal::signal_buffer"
		if (input.StartsWith("thread-local ", StringComparison.Ordinal))
			return true;
		// e.g. "non-virtual thunk to Foo::bar()"
		if (input.StartsWith("non-virtual thunk to ", StringComparison.Ordinal))
			return true;
		// e.g. "virtual thunk to Foo::bar()"
		if (input.StartsWith("virtual thunk to ", StringComparison.Ordinal))
			return true;
		// e.g. "covariant return thunk to Foo::bar()"
		if (input.StartsWith("covariant return thunk to ", StringComparison.Ordinal))
			return true;
		return false;
	}

	public static bool ParseFunction(
		string input,
		out string? returnType,
		out string? @namespace,
		out string? typeName,
		[NotNullWhen(true)] out string? functionIdentifier,
		[NotNullWhen(true)] out string? functionName,
		[NotNullWhen(true)] out string[]? templateParameters,
		[NotNullWhen(true)] out string[]? normalParameters
	)
	{
		// Short-circuit for well-known patterns that are not C++ function signatures.
		if (IsKnownUnparseable(input))
		{
			returnType = null;
			@namespace = null;
			typeName = null;
			functionIdentifier = null;
			functionName = null;
			templateParameters = null;
			normalParameters = null;
			return false;
		}

		IParseTree tree = ParseFunction(input);

		if (
			ErrorListener.HasErrors(tree)
			|| tree.ChildCount == 0
			|| (tree as ParserRuleContext)?.exception is not null
		)
		{
			Console.Error.WriteLine("Could not parse:\n" + input);
			returnType = null;
			@namespace = null;
			typeName = null;
			functionIdentifier = null;
			functionName = null;
			templateParameters = null;
			normalParameters = null;
			return false;
		}

		try
		{
			returnType = tree.GetChild(1).GetText(input).ToNullIfEmpty();
			IParseTree declaringScope = tree.GetChild(3);
			if (declaringScope.ChildCount == 0)
			{
				@namespace = null;
				typeName = null;
			}
			else if (declaringScope.GetChild(0).ChildCount > 2)
			{
				@namespace = declaringScope.GetChild(0).GetChild(0).GetText(input);
				typeName = declaringScope.GetChild(0).GetChild(3).GetText(input);
			}
			else
			{
				@namespace = null;
				typeName = declaringScope.GetChild(0).GetText(input);
			}
			IParseTree functionNameNode = tree.GetChild(4);
			string rawFunctionIdentifier = functionNameNode.GetChild(0).GetText(input);
			string rawTemplate = functionNameNode.GetChild(1).GetText(input);
			// If functionName matched the "functionIdentifier template [ ]" alternative (4 children),
			// the "[]" suffix belongs to the functionIdentifier (e.g. operator[]).
			if (functionNameNode.ChildCount == 4)
			{
				rawFunctionIdentifier += "[]";
			}
			functionIdentifier = rawFunctionIdentifier;
			functionName = rawFunctionIdentifier + rawTemplate;
			templateParameters = rawTemplate.Split(
				',',
				StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
			); // This is flawed
			normalParameters = ParseParameterList(tree.GetChild(6), input);
			if (normalParameters.Length == 1 && normalParameters[0] == "void")
			{
				normalParameters = [];
			}

			// ── Post-processing: fix known grammar misparse patterns ──────────────────
			//
			// Post-process 1: Operator conversion misparse.
			// The grammar can greedily consume "Foo::operator [modifiers]" in the
			// functionReturnType because "operator", "unsigned", "long", etc. are all
			// valid identifier tokens.  The remaining final type word (e.g. "int") is
			// then left as the functionIdentifier.
			//
			// Patterns detected (suffix of returnType after the last occurrence of
			// "::operator" or a solo "operator" prefix):
			//   suffix=""              → fi="int"/"bool"/etc.   → operator int/bool
			//   suffix=" unsigned"     → fi="int"/"long"/"short" → operator unsigned int/…
			//   suffix=" long"         → fi="long"               → operator long long
			//   suffix=" unsigned long"→ fi="long"               → operator unsigned long long
			{
				const string operatorMarker = "::operator";
				int colonOpIdx = returnType?.LastIndexOf(
					operatorMarker,
					StringComparison.Ordinal
				) ?? -1;
				bool standalone =
					colonOpIdx < 0
					&& returnType is not null
					&& (
						returnType == "operator"
						|| returnType.StartsWith("operator ", StringComparison.Ordinal)
					);

				string modifiers = "";
				string scopeBeforeOp = "";
				bool isOperatorMisparse = false;

				if (colonOpIdx >= 0)
				{
					modifiers = returnType![(colonOpIdx + operatorMarker.Length)..].Trim();
					isOperatorMisparse = IsTypeModifierOnlyString(modifiers);
					scopeBeforeOp = returnType[..colonOpIdx];
				}
				else if (standalone)
				{
					modifiers = returnType!["operator".Length..].Trim();
					isOperatorMisparse = IsTypeModifierOnlyString(modifiers);
					scopeBeforeOp = "";
				}

				if (isOperatorMisparse)
				{
					// Reconstruct the full operator type from the modifiers captured
					// in returnType and the final word left as functionName.
					string opType =
						modifiers.Length > 0 ? modifiers + " " + functionName : functionName;
					functionIdentifier = "operator " + opType;
					functionName = functionIdentifier;
					typeName = string.IsNullOrEmpty(scopeBeforeOp)
						? null
						: ExtractInnermostTypeName(scopeBeforeOp);
					returnType = null;
				}
			}
			// Post-process 2: Constructor/destructor/member function with a templated
			// declaring scope.
			// The grammar sometimes puts the class base name in returnType and only the
			// template arguments in typeName, e.g. for FPBits<float>::FPBits(float):
			//   returnType = "...::FPBits", typeName = "<float>", fi = "FPBits"
			// Detect by typeName consisting solely of template arguments (starts with '<',
			// ends with '>') when there is a non-empty returnType to steal from.
			// Skip if post-process 1 already fired (returnType was nulled out).
			if (
				returnType is not null
				&& typeName is not null
				&& typeName.StartsWith("<", StringComparison.Ordinal)
				&& typeName.EndsWith(">", StringComparison.Ordinal)
			)
			{
				// Prepend the last component of returnType (the misparsed class name) to
				// the template-args-only typeName to reconstruct the full type name.
				string lastComponent = ExtractInnermostTypeName(returnType);
				typeName = lastComponent + typeName; // e.g. "FPBits" + "<float>" = "FPBits<float>"
				// We cannot recover the true return type from this broken parse; null it
				// out so constructor/destructor detection downstream can work correctly.
				returnType = null;
			}

			return true;
		}
		catch (Exception exception)
		{
			Console.Error.WriteLine(exception);
			returnType = null;
			@namespace = null;
			typeName = null;
			functionIdentifier = null;
			functionName = null;
			templateParameters = null;
			normalParameters = null;
			return false;
		}
	}

	private static bool IsTypeModifierOnlyString(string text)
	{
		if (string.IsNullOrEmpty(text))
			return true;
		foreach (string word in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
		{
			if (word is not ("unsigned" or "signed" or "long" or "short"))
				return false;
		}
		return true;
	}

	/// <summary>
	/// Returns the last identifier component (possibly including template arguments)
	/// of a qualified C++ scope string by scanning backwards for the last <c>::</c>
	/// that is not nested inside angle brackets.
	/// <example>
	/// <c>"__llvm_libc::Errno"</c> → <c>"Errno"</c><br/>
	/// <c>"FPStorage&lt;T&gt;::TypedInt&lt;int&gt;"</c> → <c>"TypedInt&lt;int&gt;"</c>
	/// </example>
	/// </summary>
	private static string ExtractInnermostTypeName(string scope)
	{
		int depth = 0;
		for (int i = scope.Length - 1; i >= 1; i--)
		{
			char c = scope[i];
			if (c == '>') depth++;
			else if (c == '<') depth--;
			else if (depth == 0 && c == ':' && scope[i - 1] == ':')
				return scope[(i + 1)..];
		}
		return scope; // no '::' at depth 0 — return the whole string
	}

	private static string[] ParseParameterList(IParseTree parameterListNode, string input)
	{
		if (parameterListNode.ChildCount == 0)
		{
			return [];
		}

		if (parameterListNode.ChildCount == 1)
		{
			return [parameterListNode.GetChild(0).GetText(input)];
		}

		Debug.Assert(parameterListNode.ChildCount % 2 == 1);
		int parameterCount = (parameterListNode.ChildCount + 1) / 2;

		string[] parameters = new string[parameterCount];
		for (int i = 0; i < parameterCount; i++)
		{
			parameters[i] = parameterListNode.GetChild(i * 2).GetText(input);
		}

		return parameters;
	}
}
