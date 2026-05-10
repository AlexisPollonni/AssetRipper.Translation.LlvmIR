using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE15is_lowest_blockEm")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::is_lowest_block(unsigned long)")]
internal static partial class FloatToString_long_double_0_is_lowest_block_unsigned_long
{
	public unsafe static bool Invoke(void* @this, long negative_block_index)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = unchecked((int)((negative_block_index + 1L) * 9L));
		bool result = num > -unchecked((FloatToString_8m29tk*)@this)->exponent;
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
