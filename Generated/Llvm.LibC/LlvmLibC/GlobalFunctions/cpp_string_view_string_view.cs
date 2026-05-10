using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_viewC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::string_view()")]
internal static partial class cpp_string_view_string_view
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((cpp_string_view*)@this)->span_data = null;
			((cpp_string_view*)@this)->span_size = 0L;
		}
	}
}
