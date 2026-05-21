using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_long_double_0_get_positive_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE18get_positive_blockEi")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::get_positive_block(int)")]
	public unsafe static int Invoke(FloatToString_8m29tk* @this, [NativeType("int")] int block_index)
	{
		if (@this->exponent < -63)
		{
			return 0;
		}
		unchecked
		{
			if (block_index > (int)@this->block_buffer_valid || block_index < 0)
			{
				return 0;
			}
			return ((int*)(&@this->block_buffer))[block_index];
		}
	}
}
