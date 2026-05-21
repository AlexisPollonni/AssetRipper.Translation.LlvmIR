using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Accumulator_unsigned_long_advance
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword11AccumulatorImE7advanceEm")]
	[DemangledName("__llvm_libc_20_1_2_::multiword::Accumulator<unsigned long>::advance(unsigned long)")]
	public unsafe static long Invoke(void* @this, [NativeType("unsigned long")] long carry_in)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = *(long*)array_unsigned_long_2ul_front_p2cipe.Invoke((cpp_array_i3937k*)@this);
			long num2 = *(long*)array_unsigned_long_2ul_back_p5fzf7.Invoke((cpp_array_i3937k*)@this);
			*(long*)array_unsigned_long_2ul_front_p2cipe.Invoke((cpp_array_i3937k*)@this) = num2;
			*(long*)array_unsigned_long_2ul_back_p5fzf7.Invoke((cpp_array_i3937k*)@this) = carry_in;
			long result = num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
