using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sincosf_poly_eval_kyp6bv
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L17sincosf_poly_evalEldRdS0_S0_S0_.14")]
	[DemangledName("__llvm_libc_20_1_2_::sincosf_poly_eval(long, double, double&, double&, double&, double&) (.14)")]
	[CleanName("Sincosf_poly_eval")]
	public unsafe static void Invoke([MangledName("k")][NativeType("long")] long K, [MangledName("y")][NativeType("double")] double Y, [MangledName("sin_k")][NativeType("double&")] void* Sin_k, [MangledName("cos_k")][NativeType("double&")] void* Cos_k, [MangledName("sin_y")][NativeType("double&")] void* Sin_y, [MangledName("cosm1_y")][NativeType("double&")] void* Cosm1_y)
	{
		double num = 0.0;
		unchecked
		{
			*(double*)Sin_k = ((double*)SIN_K_PI_OVER_32_15.Pointer)[K & 0x3FL];
			long num2 = checked(K + 16L) & 0x3FL;
			*(double*)Cos_k = ((double*)SIN_K_PI_OVER_32_15.Pointer)[num2];
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = Y * Y;
			*(double*)Sin_y = Y * Fputil_polyeval_double_double_double_double.Invoke(num, Math.PI / 32.0, -0.00015770607849260662, 7.600080971430409E-08, -1.743752893893391E-11);
			*(double*)Cosm1_y = num * Fputil_polyeval_double_double_double.Invoke(num, -0.004819142773968786, 3.870689497597073E-06, -1.2434571561604467E-09);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
