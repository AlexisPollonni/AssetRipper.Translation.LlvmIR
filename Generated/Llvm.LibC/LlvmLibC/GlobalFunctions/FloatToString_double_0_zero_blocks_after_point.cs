using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_double_0_zero_blocks_after_point
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIdLi0EE23zero_blocks_after_pointEv")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<double, 0>::zero_blocks_after_point()")]
	public unsafe static long Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			long num = (long)((ulong)checked(-unchecked((Llvm_libc_20_1_2_FloatToString_rwjwy3*)This)->field_1) / 16uL);
			return (byte)((sbyte*)MIN_BLOCK_2_172.Pointer)[num];
		}
	}
}
