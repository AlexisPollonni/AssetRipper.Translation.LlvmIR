using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE9get_blockEi")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::get_block(int)")]
internal static partial class FloatToString_long_double_0_get_block_int
{
	public unsafe static int Invoke(FloatToString_8m29tk* @this, int block_index)
	{
		if (block_index >= 0)
		{
			return FloatToString_long_double_0_get_positive_block_int.Invoke(@this, block_index);
		}
		return FloatToString_long_double_0_get_negative_block_int.Invoke(@this, -1 - block_index);
	}
}
