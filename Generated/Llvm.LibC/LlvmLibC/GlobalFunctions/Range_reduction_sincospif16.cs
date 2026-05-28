using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Range_reduction_sincospif16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_27range_reduction_sincospif16EfRf")]
	[DemangledName("__llvm_libc_20_1_2_::range_reduction_sincospif16(float, float&)")]
	public unsafe static int Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("y")][NativeType("float&")] void* Y)
	{
		float num = 0f;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Fputil_nearest_integer.Invoke(X * 32f);
		unchecked
		{
			*(float*)Y = Fputil_multiply_add_float.Invoke(X, 32f, 0f - num);
			int result = (int)num;
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
