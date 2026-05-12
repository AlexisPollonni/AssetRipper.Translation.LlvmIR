using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal18FloatConvertReturnIfEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<float>::FloatConvertReturn()")]
internal static partial class internal_FloatConvertReturn_float_FloatConvertReturn
{
	public unsafe static void Invoke(internal_FloatConvertReturn_a8f9er* @this)
	{
		internal_ExpandedFloat_i7t5up* num = &@this->num;
		num->mantissa = 0;
		num->exponent = 0;
		@this->error = 0;
	}
}
