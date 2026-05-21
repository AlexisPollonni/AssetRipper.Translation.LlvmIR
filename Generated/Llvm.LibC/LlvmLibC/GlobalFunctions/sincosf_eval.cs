using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sincosf_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12sincosf_evalEdjRdS0_S0_S0_")]
	[DemangledName("__llvm_libc_20_1_2_::sincosf_eval(double, unsigned int, double&, double&, double&, double&)")]
	public unsafe static void Invoke([NativeType("double")] double xd, [NativeType("unsigned int")] int x_abs, [NativeType("double&")] void* sin_k, [NativeType("double&")] void* cos_k, [NativeType("double&")] void* sin_y, [NativeType("double&")] void* cosm1_y)
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
			if (details_expects_bool_condition_bool.Invoke((uint)x_abs < 1249902592u, expected: true))
			{
				k = generic_small_range_reduction.Invoke(xd, &y);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
				FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, x_abs);
				k = generic_large_range_reduction.Invoke(xd, FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_exponent.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)), &y);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			}
			sincosf_poly_eval_dr77sd.Invoke(k, y, sin_k, cos_k, sin_y, cosm1_y);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &k);
		}
	}
}
