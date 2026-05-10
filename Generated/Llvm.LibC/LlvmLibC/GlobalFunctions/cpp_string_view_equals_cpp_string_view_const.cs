using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view6equalsES1_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::equals(__llvm_libc_20_1_2_::cpp::string_view) const")]
internal static partial class cpp_string_view_equals_cpp_string_view_const
{
	public unsafe static bool Invoke(void* @this, [MangledName("Other.coerce0")] void* Other, [MangledName("Other.coerce1")] long Other_coerce1)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view2) = Other;
			((long*)(&cpp_string_view2))[1] = Other_coerce1;
			return ((cpp_string_view*)@this)->span_size == cpp_string_view2.span_size && cpp_string_view_compareMemory_char_const_char_const_unsigned_long.Invoke(((cpp_string_view*)@this)->span_data, cpp_string_view2.span_data, cpp_string_view2.span_size) == 0;
		}
	}
}
