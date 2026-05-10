using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view4sizeEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::size() const")]
internal static partial class cpp_string_view_size_const
{
	public unsafe static long Invoke(void* @this)
	{
		return unchecked((cpp_string_view*)@this)->span_size;
	}
}
