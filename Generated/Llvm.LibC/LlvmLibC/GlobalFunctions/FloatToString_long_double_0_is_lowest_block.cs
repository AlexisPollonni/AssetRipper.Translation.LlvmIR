using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_long_double_0_is_lowest_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE15is_lowest_blockEm")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::is_lowest_block(unsigned long)")]
	public unsafe static bool Invoke([MangledName("this")] FloatToString_8m29tk* This, [MangledName("negative_block_index")][NativeType("unsigned long")] long Negative_block_index)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = unchecked((int)((Negative_block_index + 1L) * 9L));
		bool result = num > -This->Exponent;
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
