using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9multiword10DoubleWideImEC2Emm")]
[DemangledName("__llvm_libc_20_1_2_::multiword::DoubleWide<unsigned long>::DoubleWide(unsigned long, unsigned long)")]
internal static partial class multiword_DoubleWide_unsigned_long_DoubleWide_unsigned_long_unsigned_long
{
	public unsafe static void Invoke(void* @this, long lo, long hi)
	{
		cpp_array_i3937k cpp_array_i3937k2 = default(cpp_array_i3937k);
		llvm_lifetime_start_p0.Invoke(16L, &cpp_array_i3937k2);
		InlineArray2_Int64* ptr = &cpp_array_i3937k2.Data;
		unchecked
		{
			*(long*)ptr = lo;
			((long*)ptr)[1] = hi;
			llvm_memcpy_p0_p0_i64.Invoke(@this, &cpp_array_i3937k2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_array_i3937k2);
		}
	}
}
