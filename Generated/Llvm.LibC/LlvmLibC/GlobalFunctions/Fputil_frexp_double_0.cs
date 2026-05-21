using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_frexp_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5frexpIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_Ri")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::frexp<double, 0>(double, int&)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("exp")][NativeType("int&")] void* Exp)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk = default(Llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, X);
			double result;
			if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)))
			{
				result = X;
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)))
			{
				*(int*)Exp = 0;
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk);
				*(int*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk) = -1431655766;
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk) + 4;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				ptr[3] = -86;
				((long*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk))[1] = -6148914691236517206L;
				((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk))[16] = -86;
				sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk) + 17;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				ptr2[4] = -86;
				ptr2[5] = -86;
				ptr2[6] = -86;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm, 8L, isVolatile: false);
				NormalFloat_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk, llvm_libc_20_1_2_fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val);
				*(int*)Exp = checked(llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk.Exponent + 1);
				llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk.Exponent = -1;
				result = NormalFloat_double_ToDouble.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
