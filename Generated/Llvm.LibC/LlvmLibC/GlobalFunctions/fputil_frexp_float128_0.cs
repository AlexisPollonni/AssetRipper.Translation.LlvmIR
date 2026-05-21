using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_frexp_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5frexpIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_Ri")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::frexp<__float128, 0>(__float128, int&)")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([NativeType("__float128")] double x, [NativeType("int&")] void* exp)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_NormalFloat_wqb3ie fputil_NormalFloat_wqb3ie2 = default(fputil_NormalFloat_wqb3ie);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi3, x);
			double result;
			if (FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi3))
			{
				result = x;
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
			{
				*(int*)exp = 0;
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie2);
				llvm_memset_p0_i64.Invoke(&fputil_NormalFloat_wqb3ie2, -86, 48L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi4, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
				NormalFloat_float128_Constructor.Invoke(&fputil_NormalFloat_wqb3ie2, *(long*)(&fputil_FPBits_ubgsi4), ((long*)(&fputil_FPBits_ubgsi4))[1]);
				*(int*)exp = checked(fputil_NormalFloat_wqb3ie2.exponent + 1);
				fputil_NormalFloat_wqb3ie2.exponent = -1;
				result = NormalFloat_float128_float128.Invoke(&fputil_NormalFloat_wqb3ie2);
				llvm_lifetime_end_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie2);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
