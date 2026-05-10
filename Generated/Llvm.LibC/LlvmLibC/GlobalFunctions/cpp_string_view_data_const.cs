using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view4dataEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::data() const")]
internal static partial class cpp_string_view_data_const
{
	public unsafe static void* Invoke(void* @this)
	{
		return unchecked((cpp_string_view*)@this)->span_data;
	}
}
