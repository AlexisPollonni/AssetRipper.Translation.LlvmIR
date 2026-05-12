using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp4spanIcE4dataEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::data() const")]
internal static partial class cpp_span_char_data_const
{
	public unsafe static void* Invoke(cpp_string_view* @this)
	{
		return @this->span_data;
	}
}
