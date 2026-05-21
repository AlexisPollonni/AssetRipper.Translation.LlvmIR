using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_sincosf_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12sincosf_evalEdjRdS0_S0_S0_")]
	[DemangledName("__llvm_libc_20_1_2_::sincosf_eval(double, unsigned int, double&, double&, double&, double&)")]
	public unsafe static void Invoke([MangledName("xd")][NativeType("double")] double Xd, [MangledName("x_abs")][NativeType("unsigned int")] int X_abs, [MangledName("sin_k")][NativeType("double&")] void* Sin_k, [MangledName("cos_k")][NativeType("double&")] void* Cos_k, [MangledName("sin_y")][NativeType("double&")] void* Sin_y, [MangledName("cosm1_y")][NativeType("double&")] void* Cosm1_y)
	{
		long k = 0L;
		double y = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_lifetime_start_p0.Invoke(8L, &k);
		k = -6148914691236517206L;
		Llvm_lifetime_start_p0.Invoke(8L, &y);
		y = double.NaN;
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke((uint)X_abs < 1249902592u, Expected: true))
			{
				k = Generic_small_range_reduction.Invoke(Xd, &y);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
				*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
				FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X_abs);
				k = Generic_large_range_reduction.Invoke(Xd, FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)), &y);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			}
			Llvm_libc_20_1_2_sincosf_poly_eval_dr77sd.Invoke(k, y, Sin_k, Cos_k, Sin_y, Cosm1_y);
			Llvm_lifetime_end_p0.Invoke(8L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &k);
		}
	}
}
