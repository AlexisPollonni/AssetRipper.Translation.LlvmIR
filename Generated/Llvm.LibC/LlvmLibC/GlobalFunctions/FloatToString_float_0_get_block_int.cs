using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIfLi0EE9get_blockEi")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<float, 0>::get_block(int)")]
internal static partial class FloatToString_float_0_get_block_int
{
	public unsafe static int Invoke(FloatToString_uyiqeh* @this, int block_index)
	{
		if (block_index >= 0)
		{
			return FloatToString_float_0_get_positive_block_int.Invoke(@this, block_index);
		}
		return FloatToString_float_0_get_negative_block_int.Invoke(@this, -1 - block_index);
	}
}
