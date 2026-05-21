using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Accumulator_unsigned_long_sum
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_9multiword11AccumulatorImE3sumEv")]
	[DemangledName("__llvm_libc_20_1_2_::multiword::Accumulator<unsigned long>::sum() const")]
	public unsafe static long Invoke(void* @this)
	{
		return *unchecked((long*)array_unsigned_long_2ul_front_j8nucq.Invoke((cpp_array_i3937k*)@this));
	}
}
