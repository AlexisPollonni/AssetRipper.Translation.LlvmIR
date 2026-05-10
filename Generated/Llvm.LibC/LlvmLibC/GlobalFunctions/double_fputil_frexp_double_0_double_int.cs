using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5frexpIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_Ri")]
[DemangledName("double __llvm_libc_20_1_2_::fputil::frexp<double, 0>(double, int&)")]
internal static partial class double_fputil_frexp_double_0_double_int
{
	public unsafe static double Invoke(double x, void* exp)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_NormalFloat_n2h9ta fputil_NormalFloat_n2h9ta2 = default(fputil_NormalFloat_n2h9ta);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			double result;
			if (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_wjhbrm2))
			{
				result = x;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke(&fputil_FPBits_wjhbrm2))
			{
				*(int*)exp = 0;
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(24L, &fputil_NormalFloat_n2h9ta2);
				*(int*)(&fputil_NormalFloat_n2h9ta2) = -1431655766;
				sbyte* ptr = (sbyte*)(&fputil_NormalFloat_n2h9ta2) + 4;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				ptr[3] = -86;
				((long*)(&fputil_NormalFloat_n2h9ta2))[1] = -6148914691236517206L;
				((sbyte*)(&fputil_NormalFloat_n2h9ta2))[16] = -86;
				sbyte* ptr2 = (sbyte*)(&fputil_NormalFloat_n2h9ta2) + 17;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				ptr2[4] = -86;
				ptr2[5] = -86;
				ptr2[6] = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm3, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
				fputil_NormalFloat_double_NormalFloat_fputil_FPBits_double.Invoke(&fputil_NormalFloat_n2h9ta2, fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val);
				*(int*)exp = checked(fputil_NormalFloat_n2h9ta2.exponent + 1);
				fputil_NormalFloat_n2h9ta2.exponent = -1;
				result = fputil_NormalFloat_double_operator_double_const.Invoke(&fputil_NormalFloat_n2h9ta2);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_NormalFloat_n2h9ta2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
