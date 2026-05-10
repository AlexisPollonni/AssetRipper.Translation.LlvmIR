using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIdLi0EE23zero_blocks_after_pointEv")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<double, 0>::zero_blocks_after_point()")]
internal static partial class FloatToString_double_0_zero_blocks_after_point
{
	public unsafe static long Invoke(void* @this)
	{
		unchecked
		{
			long num = (long)((ulong)checked(-unchecked((FloatToString_dhsqbm*)@this)->field_1) / 16uL);
			return (byte)((sbyte*)MIN_BLOCK_2_170.Pointer)[num];
		}
	}
}
