using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class range_reduction_sincosf16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_25range_reduction_sincosf16EfRf")]
	[DemangledName("__llvm_libc_20_1_2_::range_reduction_sincosf16(float, float&)")]
	public unsafe static int Invoke([NativeType("float")] float x, [NativeType("float&")] void* y)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 32.0 / Math.PI;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = (double)x * (32.0 / Math.PI);
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = fputil_nearest_integer.Invoke(num2);
		unchecked
		{
			*(float*)y = (float)(num2 - num3);
			int result = (int)num3;
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
