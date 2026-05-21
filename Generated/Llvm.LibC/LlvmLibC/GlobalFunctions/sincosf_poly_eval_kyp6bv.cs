using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sincosf_poly_eval_kyp6bv
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L17sincosf_poly_evalEldRdS0_S0_S0_.14")]
	[DemangledName("__llvm_libc_20_1_2_::sincosf_poly_eval(long, double, double&, double&, double&, double&) (.14)")]
	[CleanName("sincosf_poly_eval")]
	public unsafe static void Invoke([NativeType("long")] long k, [NativeType("double")] double y, [NativeType("double&")] void* sin_k, [NativeType("double&")] void* cos_k, [NativeType("double&")] void* sin_y, [NativeType("double&")] void* cosm1_y)
	{
		double num = 0.0;
		unchecked
		{
			*(double*)sin_k = ((double*)SIN_K_PI_OVER_32_15.Pointer)[k & 0x3FL];
			long num2 = checked(k + 16L) & 0x3FL;
			*(double*)cos_k = ((double*)SIN_K_PI_OVER_32_15.Pointer)[num2];
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = y * y;
			*(double*)sin_y = y * fputil_polyeval_double_double_double_double.Invoke(num, Math.PI / 32.0, -0.00015770607849260662, 7.600080971430409E-08, -1.743752893893391E-11);
			*(double*)cosm1_y = num * fputil_polyeval_double_double_double.Invoke(num, -0.004819142773968786, 3.870689497597073E-06, -1.2434571561604467E-09);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
