using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_viewC2EPKc")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::string_view(char const*)")]
internal static partial class cpp_string_view_string_view_char_const
{
	public unsafe static void Invoke(void* @this, void* Str)
	{
		unchecked
		{
			((cpp_string_view*)@this)->span_data = Str;
			((cpp_string_view*)@this)->span_size = cpp_string_view_length_char_const.Invoke(Str);
		}
	}
}
