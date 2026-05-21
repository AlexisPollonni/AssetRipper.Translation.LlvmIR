using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_intlogb_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7intlogbIldEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EET_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, long>::type __llvm_libc_20_1_2_::fputil::intlogb<long, double>(double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, long>::type")]
	public unsafe static long Invoke([NativeType("double")] double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv2 = default(fputil_DyadicFloat_syracv);
		int num = 0;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			long result;
			if (details_expects_bool_condition_bool.Invoke((!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) : true, expected: false))
			{
				fputil_set_errno_if_required.Invoke(33);
				fputil_raise_except_if_required.Invoke(1);
				result = ((!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? ((!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? long.MaxValue : (-2147483648L)) : (-2147483648L));
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
				*(sbyte*)(&fputil_DyadicFloat_syracv2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_syracv2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_syracv2))[1] = -1431655766;
				((long*)(&fputil_DyadicFloat_syracv2))[1] = -6148914691236517206L;
				DyadicFloat_64ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_syracv2, FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2));
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = DyadicFloat_64ul_get_unbiased_exponent.Invoke(&fputil_DyadicFloat_syracv2);
				if (details_expects_bool_condition_bool.Invoke((num <= long.MaxValue) ? (num < long.MinValue) : true, expected: false))
				{
					fputil_set_errno_if_required.Invoke(34);
					fputil_raise_except_if_required.Invoke(1);
					result = InstructionHelper.Select(num > 0, long.MaxValue, long.MinValue);
				}
				else
				{
					result = num;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
