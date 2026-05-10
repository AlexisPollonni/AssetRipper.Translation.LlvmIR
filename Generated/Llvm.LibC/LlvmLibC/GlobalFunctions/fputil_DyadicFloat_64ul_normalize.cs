using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EE9normalizeEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::normalize()")]
internal static partial class fputil_DyadicFloat_64ul_normalize
{
	public unsafe static void* Invoke(void* @this)
	{
		int num = 0;
		unchecked
		{
			if (!BigInt_64ul_false_unsigned_long_is_zero_const.Invoke(&((fputil_DyadicFloat_374hpp*)@this)->mantissa))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = cpp_enable_if_is_big_int_v_BigInt_64ul_false_unsigned_long_int_type_cpp_countl_zero_BigInt_64ul_false_unsigned_long_BigInt_64ul_false_unsigned_long_const.Invoke(&((fputil_DyadicFloat_374hpp*)@this)->mantissa);
				checked
				{
					unchecked((fputil_DyadicFloat_374hpp*)@this)->exponent -= num;
				}
				BigInt_64ul_false_unsigned_long_operator_unsigned_long_pq2pm2.Invoke(&((fputil_DyadicFloat_374hpp*)@this)->mantissa, num);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return @this;
		}
	}
}
