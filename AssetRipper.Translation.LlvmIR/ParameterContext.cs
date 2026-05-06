using AsmResolver.DotNet;
using AsmResolver.DotNet.Collections;
using AsmResolver.DotNet.Signatures;
using AssetRipper.Translation.LlvmIR.Extensions;
using LLVMSharp.Interop;

namespace AssetRipper.Translation.LlvmIR;

internal sealed class ParameterContext : BaseParameterContext
{
	public ParameterContext(LLVMValueRef parameter, Parameter definition, FunctionContext function)
		: base(definition, function)
	{
		Parameter = parameter;
		MangledName = parameter.Name ?? "";
		Attributes = AttributeWrapper.FromArray(
			function.Function.GetAttributesAtIndex((LLVMAttributeIndex)(Index + 1))
		);
		if (Index == 0 && function.Function.TryGetStructReturnType(out LLVMTypeRef type))
		{
			_cleanName = NameGenerator.CleanName(MangledName, "result");
			StructReturnTypeSignature = Module.GetTypeSignature(type);
			TypeSignature = StructReturnTypeSignature.MakePointerType();
		}
		else
		{
			_cleanName = NameGenerator.CleanName(MangledName, "");
			if (_cleanName.Length == 0)
			{
				_cleanName = $"parameter_{Index}";
			}
			TypeSignature = Module.GetTypeSignature(parameter.TypeOf);
		}
	}

	/// <summary>
	/// Overrides the clean name with a name sourced from debug info (e.g. DILocalVariable).
	/// Must be called before <see cref="IHasNameExtensions.AssignNames{T}"/> is invoked.
	/// </summary>
	internal void SetDebugName(string name) => _cleanName = name;

	/// <inheritdoc/>
	public override string MangledName { get; }

	private string _cleanName = "";

	/// <inheritdoc/>
	public override string CleanName => _cleanName;
	public override AttributeWrapper[] Attributes { get; }
	public int Index => Definition.Index;
	public LLVMValueRef Parameter { get; }
	public TypeSignature? StructReturnTypeSignature { get; }
}
