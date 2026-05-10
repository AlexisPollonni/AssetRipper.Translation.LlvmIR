using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm8EE12get_internalEm")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>::get_internal(unsigned long) const")]
internal static partial class internal_ArrayFixedSize_8ul_get_internal_unsigned_long_const
{
	public unsafe static void* Invoke(void* @this, long i)
	{
		return unchecked((byte*)((cpp_string_view*)@this)->span_data + i * 8L);
	}
}
