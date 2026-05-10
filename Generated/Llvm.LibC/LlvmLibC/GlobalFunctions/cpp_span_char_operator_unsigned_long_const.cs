using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp4spanIcEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::operator[](unsigned long) const")]
internal static partial class cpp_span_char_operator_unsigned_long_const
{
	public unsafe static void* Invoke(void* @this, long index)
	{
		return unchecked((byte*)cpp_span_char_data_const.Invoke(@this)) + index;
	}
}
