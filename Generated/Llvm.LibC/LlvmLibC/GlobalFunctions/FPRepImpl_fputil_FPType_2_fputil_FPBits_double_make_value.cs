using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_2_fputil_FPBits_double_make_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE10make_valueEmi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::make_value(unsigned long, int)")]
	public unsafe static long Invoke([NativeType("unsigned long")] long number, [NativeType("int")] int ep)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq2 = default(fputil_internal_FPRepImpl_ucubaq);
		int num = 0;
		long num2 = number;
		int num3 = ep;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_internal_FPRepImpl_ucubaq2);
		*unchecked((long*)(&fputil_internal_FPRepImpl_ucubaq2)) = -6148914691236517206L;
		FPRepImpl_fputil_FPType_2_fputil_FPBits_double_Constructor.Invoke(&fputil_internal_FPRepImpl_ucubaq2, 0L);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 53 - (64 - cpp_countl_zero_unsigned_long.Invoke(num2));
		num2 <<= unchecked((int)(uint)num);
		num3 -= num;
		if (details_expects_bool_condition_bool.Invoke(num3 >= 0, expected: true))
		{
			FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_significand.Invoke(&fputil_internal_FPRepImpl_ucubaq2, num2);
			FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent.Invoke(&fputil_internal_FPRepImpl_ucubaq2, num3 + 1);
		}
		else
		{
			unchecked
			{
				FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_significand.Invoke(&fputil_internal_FPRepImpl_ucubaq2, num2 >>> (int)(uint)checked(-num3));
			}
		}
		FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke(&fputil_internal_FPRepImpl_ucubaq2));
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_internal_FPRepImpl_ucubaq2);
		return fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val;
	}
}
