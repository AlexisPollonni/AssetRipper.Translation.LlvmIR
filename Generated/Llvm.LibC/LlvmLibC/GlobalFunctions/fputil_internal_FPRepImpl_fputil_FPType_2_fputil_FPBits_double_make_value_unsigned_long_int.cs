using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE10make_valueEmi")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::make_value(unsigned long, int)")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_make_value_unsigned_long_int
{
	public unsafe static long Invoke(long number, int ep)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq2 = default(fputil_internal_FPRepImpl_ucubaq);
		int num = 0;
		long num2 = number;
		int num3 = ep;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_internal_FPRepImpl_ucubaq2);
		*unchecked((long*)(&fputil_internal_FPRepImpl_ucubaq2)) = -6148914691236517206L;
		fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_FPRepImpl_unsigned_long.Invoke(&fputil_internal_FPRepImpl_ucubaq2, 0L);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 53 - (64 - cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countl_zero_unsigned_long_unsigned_long.Invoke(num2));
		num2 <<= unchecked((int)(uint)num);
		num3 -= num;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num3 >= 0, expected: true))
		{
			fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_significand_unsigned_long.Invoke(&fputil_internal_FPRepImpl_ucubaq2, num2);
			fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent_unsigned_long.Invoke(&fputil_internal_FPRepImpl_ucubaq2, num3 + 1);
		}
		else
		{
			unchecked
			{
				fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_significand_unsigned_long.Invoke(&fputil_internal_FPRepImpl_ucubaq2, num2 >>> (int)(uint)checked(-num3));
			}
		}
		fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_internal_FPRepImpl_ucubaq2));
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_internal_FPRepImpl_ucubaq2);
		return fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val;
	}
}
