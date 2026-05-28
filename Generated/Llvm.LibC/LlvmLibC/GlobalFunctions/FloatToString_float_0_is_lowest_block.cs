using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_float_0_is_lowest_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIfLi0EE15is_lowest_blockEm")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<float, 0>::is_lowest_block(unsigned long)")]
	public unsafe static bool Invoke([MangledName("this")] FloatToString_vnf553* This, [MangledName("negative_block_index")][NativeType("unsigned long")] long Negative_block_index)
	{
		int num = 0;
		long num2 = 0L;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (int)((ulong)checked(-This->Exponent) / 16uL);
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			long num3 = num;
			long num4 = (ushort)((short*)POW10_OFFSET_2.Pointer)[num3] + Negative_block_index;
			long num5 = num;
			num2 = num4 - (byte)((sbyte*)MIN_BLOCK_2.Pointer)[num5];
			long num6 = num2;
			long num7 = checked(num + 1);
			bool result = (ulong)num6 >= (ulong)(ushort)((short*)POW10_OFFSET_2.Pointer)[num7];
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
