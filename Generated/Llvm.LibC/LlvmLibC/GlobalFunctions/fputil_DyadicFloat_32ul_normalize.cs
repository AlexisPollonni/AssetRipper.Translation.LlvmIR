using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm32EE9normalizeEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<32ul>::normalize()")]
internal static partial class fputil_DyadicFloat_32ul_normalize
{
	public unsafe static void* Invoke(void* @this)
	{
		int num = 0;
		unchecked
		{
			if (!BigInt_32ul_false_unsigned_int_is_zero_const.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->mantissa))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = cpp_enable_if_is_big_int_v_BigInt_32ul_false_unsigned_int_int_type_cpp_countl_zero_BigInt_32ul_false_unsigned_int_BigInt_32ul_false_unsigned_int_const.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->mantissa);
				checked
				{
					unchecked((fputil_DyadicFloat_cs3nhs*)@this)->exponent -= num;
				}
				BigInt_32ul_false_unsigned_int_operator_unsigned_long_q7vm7c.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->mantissa, num);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return @this;
		}
	}
}
