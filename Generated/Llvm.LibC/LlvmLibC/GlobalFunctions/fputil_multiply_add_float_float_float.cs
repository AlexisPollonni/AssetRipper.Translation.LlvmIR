using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12multiply_addEfff")]
[DemangledName("__llvm_libc_20_1_2_::fputil::multiply_add(float, float, float)")]
internal static partial class fputil_multiply_add_float_float_float
{
	public static float Invoke(float x, float y, float z)
	{
		return llvm_fma_f32.Invoke(x, y, z);
	}
}
