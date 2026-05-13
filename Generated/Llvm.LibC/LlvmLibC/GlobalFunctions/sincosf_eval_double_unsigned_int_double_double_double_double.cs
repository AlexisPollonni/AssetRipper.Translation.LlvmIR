using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12sincosf_evalEdjRdS0_S0_S0_")]
[DemangledName("__llvm_libc_20_1_2_::sincosf_eval(double, unsigned int, double&, double&, double&, double&)")]
internal static partial class sincosf_eval_double_unsigned_int_double_double_double_double
{
	public unsafe static void Invoke(double xd, int x_abs, void* sin_k, void* cos_k, void* sin_y, void* cosm1_y)
	{
		long k = 0L;
		double y = 0.0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		llvm_lifetime_start_p0.Invoke(8L, &k);
		k = -6148914691236517206L;
		llvm_lifetime_start_p0.Invoke(8L, &y);
		y = double.NaN;
		unchecked
		{
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)x_abs < 1442840576u, expected: true))
			{
				k = fma_small_range_reduction_double_double.Invoke(xd, &y);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
				fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, x_abs);
				k = fma_large_range_reduction_double_int_double.Invoke(xd, fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_exponent_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)), &y);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			}
			sincosf_poly_eval_long_double_double_double_double_double.Invoke(k, y, sin_k, cos_k, sin_y, cosm1_y);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &k);
		}
	}
}
