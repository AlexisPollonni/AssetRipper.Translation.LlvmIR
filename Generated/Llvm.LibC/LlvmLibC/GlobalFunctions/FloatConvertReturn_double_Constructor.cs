using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatConvertReturn_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18FloatConvertReturnIdEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<double>::FloatConvertReturn()")]
	public unsafe static void Invoke([MangledName("this")] Internal_FloatConvertReturn_g92bm8* This)
	{
		Internal_ExpandedFloat_k68bhv* num = &This->Num;
		num->Mantissa = 0L;
		num->Exponent = 0;
		This->Error = 0;
	}
}
