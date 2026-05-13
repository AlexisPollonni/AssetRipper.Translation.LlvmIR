using System.Collections;
using System.Diagnostics.CodeAnalysis;
using AsmResolver.DotNet;
using AsmResolver.DotNet.Signatures;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace AssetRipper.Translation.LlvmIR;

internal sealed partial class ModuleContext
{
	internal sealed class RuntimeTypeImporter : IReadOnlyDictionary<Type, TypeDefinition>
	{
		public RuntimeTypeImporter(ModuleDefinition targetModule)
		{
			TargetModule = targetModule;
			SourceModule = ModuleDefinition.FromFile(typeof(IntrinsicFunctions).Assembly.Location);

			foreach (Type type in ManagedTypes)
			{
				TypeDefinition? found = SourceModule.TopLevelTypes.FirstOrDefault(t =>
					t.Namespace == type.Namespace && t.Name == type.Name
				);
				// Nested types (e.g. none currently, but future-proof)
				if (found is null)
				{
					foreach (TypeDefinition topType in SourceModule.TopLevelTypes)
					{
						found = topType.NestedTypes.FirstOrDefault(t => t.Name == type.Name);
						if (found is not null)
							break;
					}
				}
				if (found is not null)
					TypeMap.Add(type, found);
			}
		}

		private ModuleDefinition TargetModule { get; }
		private ModuleDefinition SourceModule { get; }
		private Dictionary<Type, TypeDefinition> TypeMap { get; } = new();

		/// <summary>All types sourced from the Runtime assembly that RuntimeImporter manages.</summary>
		private static readonly Type[] ManagedTypes =
		[
			typeof(IntrinsicFunctions),
			typeof(InlineArrayHelper),
			typeof(InlineArrayBuilder<,>),
			typeof(IInlineArray<>),
			typeof(IInlineArray<,>),
			typeof(SpanHelper),
			typeof(InstructionHelper),
			typeof(NumericHelper),
			typeof(InlineArrayNumericHelper),
			typeof(NameAttribute),
			typeof(MangledNameAttribute),
			typeof(DemangledNameAttribute),
			typeof(CleanNameAttribute),
			typeof(NativeTypeAttribute),
			typeof(InlineAssemblyAttribute),
			typeof(MightThrowAttribute),
			typeof(ExceptionInfo),
			typeof(StackFrame),
			typeof(StackFrameList),
			typeof(FatalException),
			typeof(PointerIndices),
			typeof(NativeMemoryHelper),
		];

		/// <summary>The fixed namespace for all Runtime attribute types.</summary>
		public static readonly string AttributesNamespace = typeof(MangledNameAttribute).Namespace!;

		// ─── Import helpers ───────────────────────────────────────────────────

		/// <summary>Import a <see cref="MethodDefinition"/> from the Runtime module into the target module.</summary>
		public IMethodDefOrRef ImportMethod(MethodDefinition method) =>
			(IMethodDefOrRef)TargetModule.DefaultImporter.ImportMethod(method);

		/// <summary>Import a <see cref="FieldDefinition"/> from the Runtime module into the target module.</summary>
		public IFieldDescriptor ImportField(FieldDefinition field) =>
			(IFieldDescriptor)TargetModule.DefaultImporter.ImportField(field);

		/// <summary>Get a <see cref="TypeSignature"/> referencing a Runtime type.</summary>
		public TypeSignature GetTypeSignature(Type type) =>
			TargetModule.DefaultImporter.ImportTypeSignature(type);

		/// <summary>Get an <see cref="ITypeDefOrRef"/> referencing a Runtime type.</summary>
		public ITypeDefOrRef GetTypeRef(Type type) => TargetModule.DefaultImporter.ImportType(type);

		/// <summary>
		/// Build a <see cref="GenericInstanceTypeSignature"/> for a Runtime generic type, e.g.
		/// <c>IInlineArray&lt;T&gt;</c>.
		/// </summary>
		public GenericInstanceTypeSignature MakeGenericType(
			Type openType,
			params TypeSignature[] typeArgs
		) => TargetModule.DefaultImporter.ImportType(openType).MakeGenericInstanceType(typeArgs);

		// ─── IReadOnlyDictionary ──────────────────────────────────────────────

		public TypeDefinition this[Type type] => TypeMap[type];

		IEnumerable<Type> IReadOnlyDictionary<Type, TypeDefinition>.Keys => TypeMap.Keys;

		IEnumerable<TypeDefinition> IReadOnlyDictionary<Type, TypeDefinition>.Values =>
			TypeMap.Values;

		int IReadOnlyCollection<KeyValuePair<Type, TypeDefinition>>.Count => TypeMap.Count;

		bool IReadOnlyDictionary<Type, TypeDefinition>.ContainsKey(Type key) =>
			TypeMap.ContainsKey(key);

		bool IReadOnlyDictionary<Type, TypeDefinition>.TryGetValue(
			Type key,
			[MaybeNullWhen(false)] out TypeDefinition value
		) => TypeMap.TryGetValue(key, out value);

		IEnumerator<KeyValuePair<Type, TypeDefinition>> IEnumerable<
			KeyValuePair<Type, TypeDefinition>
		>.GetEnumerator() => TypeMap.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => TypeMap.GetEnumerator();
	}
}
