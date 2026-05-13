using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_9multiword11AccumulatorImE3sumEv")]
[DemangledName("__llvm_libc_20_1_2_::multiword::Accumulator<unsigned long>::sum() const")]
internal static partial class multiword_Accumulator_unsigned_long_sum_const
{
	public unsafe static long Invoke(void* @this)
	{
		return *unchecked((long*)cpp_array_unsigned_long_2ul_front_const.Invoke((cpp_array_i3937k*)@this));
	}
}
