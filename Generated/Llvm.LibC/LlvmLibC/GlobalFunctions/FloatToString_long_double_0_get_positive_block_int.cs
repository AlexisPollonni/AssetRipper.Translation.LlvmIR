using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE18get_positive_blockEi")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::get_positive_block(int)")]
internal static partial class FloatToString_long_double_0_get_positive_block_int
{
	public unsafe static int Invoke(void* @this, int block_index)
	{
		unchecked
		{
			if (((FloatToString_8m29tk*)@this)->exponent < -63)
			{
				return 0;
			}
			if (block_index > (int)((FloatToString_8m29tk*)@this)->block_buffer_valid || block_index < 0)
			{
				return 0;
			}
			return ((int*)(&((FloatToString_8m29tk*)@this)->block_buffer))[block_index];
		}
	}
}
