using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatConvertReturn_long_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18FloatConvertReturnIeEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<long double>::FloatConvertReturn()")]
	public unsafe static void Invoke(internal_FloatConvertReturn_hgyipa* @this)
	{
		internal_ExpandedFloat_9jummq* num = &@this->num;
		num->mantissa = 0L;
		num->exponent = 0;
		@this->error = 0;
	}
}
