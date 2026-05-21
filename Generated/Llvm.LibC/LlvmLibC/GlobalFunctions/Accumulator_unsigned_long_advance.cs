using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Accumulator_unsigned_long_advance
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword11AccumulatorImE7advanceEm")]
	[DemangledName("__llvm_libc_20_1_2_::multiword::Accumulator<unsigned long>::advance(unsigned long)")]
	public unsafe static long Invoke([MangledName("this")] void* This, [MangledName("carry_in")][NativeType("unsigned long")] long Carry_in)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = *(long*)Array_unsigned_long_2ul_front_p2cipe.Invoke((Llvm_libc_20_1_2_cpp_array_i3937k*)This);
			long num2 = *(long*)Array_unsigned_long_2ul_back_p5fzf7.Invoke((Llvm_libc_20_1_2_cpp_array_i3937k*)This);
			*(long*)Array_unsigned_long_2ul_front_p2cipe.Invoke((Llvm_libc_20_1_2_cpp_array_i3937k*)This) = num2;
			*(long*)Array_unsigned_long_2ul_back_p5fzf7.Invoke((Llvm_libc_20_1_2_cpp_array_i3937k*)This) = Carry_in;
			long result = num;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
