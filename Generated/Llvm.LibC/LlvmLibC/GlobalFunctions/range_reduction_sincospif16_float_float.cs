using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_27range_reduction_sincospif16EfRf")]
[DemangledName("__llvm_libc_20_1_2_::range_reduction_sincospif16(float, float&)")]
internal static partial class range_reduction_sincospif16_float_float
{
	public unsafe static int Invoke(float x, void* y)
	{
		float num = 0f;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = fputil_nearest_integer_float.Invoke(x * 32f);
		unchecked
		{
			*(float*)y = cpp_enable_if_sizeof_float_8ul_float_type_fputil_multiply_add_float_float_float_float.Invoke(x, 32f, 0f - num);
			int result = (int)num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
