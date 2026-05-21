using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatConvertReturn_long_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18FloatConvertReturnIeEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<long double>::FloatConvertReturn()")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_internal_FloatConvertReturn_hgyipa* This)
	{
		Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq* num = &This->Num;
		num->Mantissa = 0L;
		num->Exponent = 0;
		This->Error = 0;
	}
}
