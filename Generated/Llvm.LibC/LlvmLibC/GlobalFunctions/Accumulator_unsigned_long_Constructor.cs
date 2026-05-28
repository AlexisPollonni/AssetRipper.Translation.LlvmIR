using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Accumulator_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword11AccumulatorImEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::multiword::Accumulator<unsigned long>::Accumulator()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		Cpp_array_i3937k cpp_array_i3937k = default(Cpp_array_i3937k);
		Llvm_lifetime_start_p0.Invoke(16L, &cpp_array_i3937k);
		InlineArray2_Int64* ptr = &cpp_array_i3937k.Data;
		unchecked
		{
			*(long*)ptr = 0L;
			((long*)ptr)[1] = 0L;
			Llvm_memcpy_p0_p0_i64.Invoke(This, &cpp_array_i3937k, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &cpp_array_i3937k);
		}
	}
}
