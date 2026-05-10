using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_viewC2EPKcm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::string_view(char const*, unsigned long)")]
internal static partial class cpp_string_view_string_view_char_const_unsigned_long
{
	public unsafe static void Invoke(void* @this, void* Str, long N)
	{
		unchecked
		{
			((cpp_string_view*)@this)->span_data = Str;
			((cpp_string_view*)@this)->span_size = N;
		}
	}
}
