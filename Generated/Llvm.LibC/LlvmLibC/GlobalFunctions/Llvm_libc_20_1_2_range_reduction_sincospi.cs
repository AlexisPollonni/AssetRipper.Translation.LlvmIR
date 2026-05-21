using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_range_reduction_sincospi
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L24range_reduction_sincospiEdRd")]
	[DemangledName("__llvm_libc_20_1_2_::range_reduction_sincospi(double, double&)")]
	public unsafe static long Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("y")][NativeType("double&")] void* Y)
	{
		double num = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Fputil_nearest_integer.Invoke(X * 32.0);
		unchecked
		{
			*(double*)Y = Fputil_multiply_add_double.Invoke(X, 32.0, 0.0 - num);
			long result = (long)num;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
