using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_double_0_get_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIdLi0EE9get_blockEi")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<double, 0>::get_block(int)")]
	public unsafe static int Invoke([MangledName("this")] void* This, [MangledName("block_index")][NativeType("int")] int Block_index)
	{
		if (Block_index >= 0)
		{
			return FloatToString_double_0_get_positive_block.Invoke(This, Block_index);
		}
		return FloatToString_double_0_get_negative_block.Invoke(This, -1 - Block_index);
	}
}
