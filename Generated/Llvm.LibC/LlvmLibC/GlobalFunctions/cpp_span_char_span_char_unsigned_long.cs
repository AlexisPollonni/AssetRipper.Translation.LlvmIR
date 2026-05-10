using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4spanIcEC2EPcm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::span(char*, unsigned long)")]
internal static partial class cpp_span_char_span_char_unsigned_long
{
	public unsafe static void Invoke(void* @this, void* first, long count)
	{
		unchecked
		{
			((cpp_string_view*)@this)->span_data = first;
			((cpp_string_view*)@this)->span_size = count;
		}
	}
}
