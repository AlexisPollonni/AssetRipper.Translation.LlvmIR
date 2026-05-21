using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Accumulator_unsigned_long_carry
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_9multiword11AccumulatorImE5carryEv")]
	[DemangledName("__llvm_libc_20_1_2_::multiword::Accumulator<unsigned long>::carry() const")]
	public unsafe static long Invoke([MangledName("this")] void* This)
	{
		return *unchecked((long*)Array_unsigned_long_2ul_back_g5j3kr.Invoke((Llvm_libc_20_1_2_cpp_array_i3937k*)This));
	}
}
