using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_viewixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::operator[](unsigned long) const")]
internal static partial class cpp_string_view_operator_unsigned_long_const
{
	public unsafe static void* Invoke(void* @this, long Index)
	{
		return unchecked((byte*)((cpp_string_view*)@this)->span_data) + Index;
	}
}
