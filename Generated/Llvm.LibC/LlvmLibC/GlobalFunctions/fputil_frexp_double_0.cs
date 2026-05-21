using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_frexp_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5frexpIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_Ri")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::frexp<double, 0>(double, int&)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([NativeType("double")] double x, [NativeType("int&")] void* exp)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_NormalFloat_vc4yvk fputil_NormalFloat_vc4yvk2 = default(fputil_NormalFloat_vc4yvk);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			double result;
			if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)))
			{
				result = x;
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				*(int*)exp = 0;
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(24L, &fputil_NormalFloat_vc4yvk2);
				*(int*)(&fputil_NormalFloat_vc4yvk2) = -1431655766;
				sbyte* ptr = (sbyte*)(&fputil_NormalFloat_vc4yvk2) + 4;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				ptr[3] = -86;
				((long*)(&fputil_NormalFloat_vc4yvk2))[1] = -6148914691236517206L;
				((sbyte*)(&fputil_NormalFloat_vc4yvk2))[16] = -86;
				sbyte* ptr2 = (sbyte*)(&fputil_NormalFloat_vc4yvk2) + 17;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				ptr2[4] = -86;
				ptr2[5] = -86;
				ptr2[6] = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm3, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
				NormalFloat_double_Constructor.Invoke(&fputil_NormalFloat_vc4yvk2, fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val);
				*(int*)exp = checked(fputil_NormalFloat_vc4yvk2.exponent + 1);
				fputil_NormalFloat_vc4yvk2.exponent = -1;
				result = NormalFloat_double_ToDouble.Invoke(&fputil_NormalFloat_vc4yvk2);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_NormalFloat_vc4yvk2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
