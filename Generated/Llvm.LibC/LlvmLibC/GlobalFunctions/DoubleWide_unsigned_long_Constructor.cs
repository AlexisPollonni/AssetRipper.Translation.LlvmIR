using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DoubleWide_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword10DoubleWideImEC2Emm")]
	[DemangledName("__llvm_libc_20_1_2_::multiword::DoubleWide<unsigned long>::DoubleWide(unsigned long, unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("lo")][NativeType("unsigned long")] long Lo, [MangledName("hi")][NativeType("unsigned long")] long Hi)
	{
		Cpp_array_i3937k cpp_array_i3937k = default(Cpp_array_i3937k);
		Llvm_lifetime_start_p0.Invoke(16L, &cpp_array_i3937k);
		InlineArray2_Int64* ptr = &cpp_array_i3937k.Data;
		unchecked
		{
			*(long*)ptr = Lo;
			((long*)ptr)[1] = Hi;
			Llvm_memcpy_p0_p0_i64.Invoke(This, &cpp_array_i3937k, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &cpp_array_i3937k);
		}
	}
}
