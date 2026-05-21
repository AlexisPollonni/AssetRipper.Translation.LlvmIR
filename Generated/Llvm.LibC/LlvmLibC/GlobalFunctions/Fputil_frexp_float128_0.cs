using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_frexp_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5frexpIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_Ri")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::frexp<__float128, 0>(__float128, int&)")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([MangledName("x")][NativeType("__float128")] double X, [MangledName("exp")][NativeType("int&")] void* Exp)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie = default(Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, X);
			double result;
			if (FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
			{
				result = X;
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)))
			{
				*(int*)Exp = 0;
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(48L, &llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie);
				Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie, -86, 48L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2, &llvm_libc_20_1_2_fputil_FPBits_ubgsi, 16L, isVolatile: false);
				NormalFloat_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie, *(long*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2), ((long*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2))[1]);
				*(int*)Exp = checked(llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie.Exponent + 1);
				llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie.Exponent = -1;
				result = NormalFloat_float128_Float128.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie);
				Llvm_lifetime_end_p0.Invoke(48L, &llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			return result;
		}
	}
}
