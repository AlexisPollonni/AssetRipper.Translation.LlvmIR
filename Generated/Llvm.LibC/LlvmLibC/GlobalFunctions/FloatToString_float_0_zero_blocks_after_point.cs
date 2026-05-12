using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIfLi0EE23zero_blocks_after_pointEv")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<float, 0>::zero_blocks_after_point()")]
internal static partial class FloatToString_float_0_zero_blocks_after_point
{
	public unsafe static long Invoke(FloatToString_uyiqeh* @this)
	{
		unchecked
		{
			long num = (long)((ulong)checked(-@this->exponent) / 16uL);
			return (byte)((sbyte*)MIN_BLOCK_2.Pointer)[num];
		}
	}
}
