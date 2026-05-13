using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm256EE9normalizeEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>::normalize()")]
internal static partial class fputil_DyadicFloat_256ul_normalize
{
	public unsafe static fputil_DyadicFloat_jhcpjj* Invoke(fputil_DyadicFloat_jhcpjj* @this)
	{
		int num = 0;
		if (!BigInt_256ul_false_unsigned_long_is_zero_const.Invoke(&@this->mantissa))
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = cpp_enable_if_is_big_int_v_BigInt_256ul_false_unsigned_long_int_type_cpp_countl_zero_BigInt_256ul_false_unsigned_long_BigInt_256ul_false_unsigned_long_const.Invoke(&@this->mantissa);
			@this->exponent -= num;
			BigInt_256ul_false_unsigned_long_operator_unsigned_long_d84zyi.Invoke(&@this->mantissa, num);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return @this;
	}
}
