using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9multiword11AccumulatorImE7advanceEm")]
[DemangledName("__llvm_libc_20_1_2_::multiword::Accumulator<unsigned long>::advance(unsigned long)")]
internal static partial class multiword_Accumulator_unsigned_long_advance_unsigned_long
{
	public unsafe static long Invoke(void* @this, long carry_in)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = *(long*)cpp_array_unsigned_long_2ul_front.Invoke((cpp_array_i3937k*)@this);
			long num2 = *(long*)cpp_array_unsigned_long_2ul_back.Invoke((cpp_array_i3937k*)@this);
			*(long*)cpp_array_unsigned_long_2ul_front.Invoke((cpp_array_i3937k*)@this) = num2;
			*(long*)cpp_array_unsigned_long_2ul_back.Invoke((cpp_array_i3937k*)@this) = carry_in;
			long result = num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
