using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatConvertReturn_float_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18FloatConvertReturnIfEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<float>::FloatConvertReturn()")]
	public unsafe static void Invoke([MangledName("this")] Internal_FloatConvertReturn_a8f9er* This)
	{
		Internal_ExpandedFloat_i7t5up* num = &This->Num;
		num->Mantissa = 0;
		num->Exponent = 0;
		This->Error = 0;
	}
}
