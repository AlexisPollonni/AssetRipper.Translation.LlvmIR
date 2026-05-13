using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm16EE9normalizeEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<16ul>::normalize()")]
internal static partial class fputil_DyadicFloat_16ul_normalize
{
	public unsafe static fputil_DyadicFloat_jvghxm* Invoke(fputil_DyadicFloat_jvghxm* @this)
	{
		int num = 0;
		if (!BigInt_16ul_false_unsigned_short_is_zero_const.Invoke(&@this->mantissa))
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = cpp_enable_if_is_big_int_v_BigInt_16ul_false_unsigned_short_int_type_cpp_countl_zero_BigInt_16ul_false_unsigned_short_BigInt_16ul_false_unsigned_short_const.Invoke(&@this->mantissa);
			@this->exponent -= num;
			BigInt_16ul_false_unsigned_short_operator_unsigned_long_5gbked.Invoke(&@this->mantissa, num);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return @this;
	}
}
