using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal18FloatConvertReturnIfEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<float>::FloatConvertReturn()")]
internal static partial class internal_FloatConvertReturn_float_FloatConvertReturn
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			internal_ExpandedFloat_i7t5up* num = &((internal_FloatConvertReturn_a8f9er*)@this)->num;
			num->mantissa = 0;
			num->exponent = 0;
			((internal_FloatConvertReturn_a8f9er*)@this)->error = 0;
		}
	}
}
