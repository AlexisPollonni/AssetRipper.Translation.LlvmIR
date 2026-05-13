using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5frexpIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_Ri")]
[DemangledName("long double __llvm_libc_20_1_2_::fputil::frexp<long double, 0>(long double, int&)")]
internal static partial class long_double_fputil_frexp_long_double_0_long_double_int
{
	public unsafe static double Invoke(double x, void* exp)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_NormalFloat_wqb3ie fputil_NormalFloat_wqb3ie2 = default(fputil_NormalFloat_wqb3ie);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, x);
			double result;
			if (fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				result = x;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				*(int*)exp = 0;
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie2);
				llvm_memset_p0_i64.Invoke(&fputil_NormalFloat_wqb3ie2, -86, 48L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi4, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
				fputil_NormalFloat_long_double_NormalFloat_fputil_FPBits_long_double.Invoke(&fputil_NormalFloat_wqb3ie2, *(long*)(&fputil_FPBits_ubgsi4), ((long*)(&fputil_FPBits_ubgsi4))[1]);
				*(int*)exp = checked(fputil_NormalFloat_wqb3ie2.exponent + 1);
				fputil_NormalFloat_wqb3ie2.exponent = -1;
				result = fputil_NormalFloat_long_double_operator_long_double_const.Invoke(&fputil_NormalFloat_wqb3ie2);
				llvm_lifetime_end_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie2);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
