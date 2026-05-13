using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIdLi0EE15is_lowest_blockEm")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<double, 0>::is_lowest_block(unsigned long)")]
internal static partial class FloatToString_double_0_is_lowest_block_unsigned_long
{
	public unsafe static bool Invoke(void* @this, long negative_block_index)
	{
		int num = 0;
		long num2 = 0L;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (int)((ulong)checked(-unchecked((FloatToString_dhsqbm*)@this)->field_1) / 16uL);
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			long num3 = num;
			long num4 = (ushort)((short*)POW10_OFFSET_2_171.Pointer)[num3] + negative_block_index;
			long num5 = num;
			num2 = num4 - (byte)((sbyte*)MIN_BLOCK_2_170.Pointer)[num5];
			long num6 = num2;
			long num7 = checked(num + 1);
			bool result = (ulong)num6 >= (ulong)(ushort)((short*)POW10_OFFSET_2_171.Pointer)[num7];
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
