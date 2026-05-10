using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm4EE12reset_boundsEmm")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>::reset_bounds(unsigned long, unsigned long)")]
internal static partial class internal_ArrayFixedSize_4ul_reset_bounds_unsigned_long_unsigned_long
{
	public unsafe static void Invoke(void* @this, long i, long s)
	{
		unchecked
		{
			((cpp_string_view*)@this)->span_data = internal_ArrayFixedSize_4ul_get_internal_unsigned_long_const.Invoke(@this, i);
			((cpp_string_view*)@this)->span_size = s;
		}
	}
}
