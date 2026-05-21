using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_long_double_0_get_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE9get_blockEi")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::get_block(int)")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_FloatToString_8m29tk* This, [MangledName("block_index")][NativeType("int")] int Block_index)
	{
		if (Block_index >= 0)
		{
			return FloatToString_long_double_0_get_positive_block.Invoke(This, Block_index);
		}
		return FloatToString_long_double_0_get_negative_block.Invoke(This, -1 - Block_index);
	}
}
