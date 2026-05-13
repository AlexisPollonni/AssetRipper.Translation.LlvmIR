using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9multiword11AccumulatorImEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::multiword::Accumulator<unsigned long>::Accumulator()")]
internal static partial class multiword_Accumulator_unsigned_long_Accumulator
{
	public unsafe static void Invoke(void* @this)
	{
		cpp_array_i3937k cpp_array_i3937k2 = default(cpp_array_i3937k);
		llvm_lifetime_start_p0.Invoke(16L, &cpp_array_i3937k2);
		InlineArray2_Int64* ptr = &cpp_array_i3937k2.Data;
		unchecked
		{
			*(long*)ptr = 0L;
			((long*)ptr)[1] = 0L;
			llvm_memcpy_p0_p0_i64.Invoke(@this, &cpp_array_i3937k2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_array_i3937k2);
		}
	}
}
