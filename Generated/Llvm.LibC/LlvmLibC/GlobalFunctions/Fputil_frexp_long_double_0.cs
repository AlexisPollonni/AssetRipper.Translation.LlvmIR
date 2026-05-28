using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_frexp_long_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5frexpIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_Ri")]
	[DemangledName("long double __llvm_libc_20_1_2_::fputil::frexp<long double, 0>(long double, int&)")]
	[return: NativeType("long double")]
	public unsafe static double Invoke([MangledName("x")][NativeType("long double")] double X, [MangledName("exp")][NativeType("int&")] void* Exp)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Fputil_NormalFloat_wqb3ie fputil_NormalFloat_wqb3ie = default(Fputil_NormalFloat_wqb3ie);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi, X);
			double result;
			if (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi))
			{
				result = X;
			}
			else if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi))
			{
				*(int*)Exp = 0;
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie);
				Llvm_memset_p0_i64.Invoke(&fputil_NormalFloat_wqb3ie, -86, 48L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi2, &fputil_FPBits_ubgsi, 16L, isVolatile: false);
				NormalFloat_long_double_Constructor.Invoke(&fputil_NormalFloat_wqb3ie, *(long*)(&fputil_FPBits_ubgsi2), ((long*)(&fputil_FPBits_ubgsi2))[1]);
				*(int*)Exp = checked(fputil_NormalFloat_wqb3ie.Exponent + 1);
				fputil_NormalFloat_wqb3ie.Exponent = -1;
				result = NormalFloat_long_double_Long_double.Invoke(&fputil_NormalFloat_wqb3ie);
				Llvm_lifetime_end_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			return result;
		}
	}
}
