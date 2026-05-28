using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_long_double_0_get_positive_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE18get_positive_blockEi")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::get_positive_block(int)")]
	public unsafe static int Invoke([MangledName("this")] FloatToString_8m29tk* This, [MangledName("block_index")][NativeType("int")] int Block_index)
	{
		if (This->Exponent < -63)
		{
			return 0;
		}
		unchecked
		{
			if (Block_index > (int)This->Block_buffer_valid || Block_index < 0)
			{
				return 0;
			}
			return ((int*)(&This->Block_buffer))[Block_index];
		}
	}
}
