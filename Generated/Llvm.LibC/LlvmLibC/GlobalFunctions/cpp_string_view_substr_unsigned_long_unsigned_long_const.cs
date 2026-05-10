using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view6substrEmm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::substr(unsigned long, unsigned long) const")]
internal static partial class cpp_string_view_substr_unsigned_long_unsigned_long_const
{
	public unsafe static Struct_kqhe8i Invoke(void* @this, long Start, long N)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		long a = Start;
		unchecked
		{
			a = cpp_string_view_min_unsigned_long_unsigned_long.Invoke(a, ((cpp_string_view*)@this)->span_size);
			cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, (byte*)((cpp_string_view*)@this)->span_data + a, cpp_string_view_min_unsigned_long_unsigned_long.Invoke(N, ((cpp_string_view*)@this)->span_size - a));
			return *(Struct_kqhe8i*)(&cpp_string_view2);
		}
	}
}
