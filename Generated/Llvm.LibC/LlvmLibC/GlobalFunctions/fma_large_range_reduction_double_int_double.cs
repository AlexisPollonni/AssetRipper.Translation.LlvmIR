using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3fma21large_range_reductionEdiRd")]
[DemangledName("__llvm_libc_20_1_2_::fma::large_range_reduction(double, int, double&)")]
internal static partial class fma_large_range_reduction_double_int_double
{
	public unsafe static long Invoke(double x, int x_exp, void* y)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		double num = 0.0;
		double num2 = 0.0;
		double x2 = 0.0;
		double num3 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		double num4 = 0.0;
		double num5 = 0.0;
		double x3 = 0.0;
		double num6 = 0.0;
		unchecked
		{
			long result;
			if (x_exp < 99)
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x * *(double*)fma_THIRTYTWO_OVER_PI.Pointer);
				fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_uintval_unsigned_long.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2), fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) & InstructionHelper.Select(x_exp < 55, -4096L, -1L));
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = fputil_nearest_integer_double.Invoke(fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2));
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = double_fputil_fma_double_double_double_double_double.Invoke(x, *(double*)fma_THIRTYTWO_OVER_PI.Pointer, 0.0 - num);
				llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = double_fputil_fma_double_double_double_double_double.Invoke(x, ((double*)fma_THIRTYTWO_OVER_PI.Pointer)[1], num2);
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = fputil_nearest_integer_double.Invoke(x2);
				*(double*)y = double_fputil_fma_double_double_double_double_double.Invoke(x, ((double*)fma_THIRTYTWO_OVER_PI.Pointer)[1], num2 - num3);
				*(double*)y = double_fputil_fma_double_double_double_double_double.Invoke(x, ((double*)fma_THIRTYTWO_OVER_PI.Pointer)[2L], *(double*)y);
				*(double*)y = double_fputil_fma_double_double_double_double_double.Invoke(x, ((double*)fma_THIRTYTWO_OVER_PI.Pointer)[3L], *(double*)y);
				result = (long)num3;
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &x2);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
				llvm_lifetime_end_p0.Invoke(8L, &num);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, x * ((double*)fma_THIRTYTWO_OVER_PI.Pointer)[1]);
				fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_uintval_unsigned_long.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3), fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3)) & InstructionHelper.Select(x_exp < 110, -4096L, -1L));
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = fputil_nearest_integer_double.Invoke(fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3));
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = double_fputil_fma_double_double_double_double_double.Invoke(x, ((double*)fma_THIRTYTWO_OVER_PI.Pointer)[1], 0.0 - num4);
				llvm_lifetime_start_p0.Invoke(8L, &x3);
				x3 = double_fputil_fma_double_double_double_double_double.Invoke(x, ((double*)fma_THIRTYTWO_OVER_PI.Pointer)[2L], num5);
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = fputil_nearest_integer_double.Invoke(x3);
				*(double*)y = double_fputil_fma_double_double_double_double_double.Invoke(x, ((double*)fma_THIRTYTWO_OVER_PI.Pointer)[2L], num5 - num6);
				*(double*)y = double_fputil_fma_double_double_double_double_double.Invoke(x, ((double*)fma_THIRTYTWO_OVER_PI.Pointer)[3L], *(double*)y);
				*(double*)y = double_fputil_fma_double_double_double_double_double.Invoke(x, ((double*)fma_THIRTYTWO_OVER_PI.Pointer)[4L], *(double*)y);
				result = (long)num6;
				llvm_lifetime_end_p0.Invoke(8L, &num6);
				llvm_lifetime_end_p0.Invoke(8L, &x3);
				llvm_lifetime_end_p0.Invoke(8L, &num5);
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			}
			return result;
		}
	}
}
