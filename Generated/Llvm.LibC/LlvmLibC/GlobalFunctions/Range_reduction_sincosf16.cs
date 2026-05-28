using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Range_reduction_sincosf16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_25range_reduction_sincosf16EfRf")]
	[DemangledName("__llvm_libc_20_1_2_::range_reduction_sincosf16(float, float&)")]
	public unsafe static int Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("y")][NativeType("float&")] void* Y)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 32.0 / Math.PI;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = (double)X * (32.0 / Math.PI);
		Llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = Fputil_nearest_integer.Invoke(num2);
		unchecked
		{
			*(float*)Y = (float)(num2 - num3);
			int result = (int)num3;
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
