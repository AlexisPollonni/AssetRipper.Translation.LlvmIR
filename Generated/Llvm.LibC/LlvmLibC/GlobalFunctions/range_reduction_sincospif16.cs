using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class range_reduction_sincospif16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_27range_reduction_sincospif16EfRf")]
	[DemangledName("__llvm_libc_20_1_2_::range_reduction_sincospif16(float, float&)")]
	public unsafe static int Invoke([NativeType("float")] float x, [NativeType("float&")] void* y)
	{
		float num = 0f;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = fputil_nearest_integer.Invoke(x * 32f);
		unchecked
		{
			*(float*)y = fputil_multiply_add_float.Invoke(x, 32f, 0f - num);
			int result = (int)num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
