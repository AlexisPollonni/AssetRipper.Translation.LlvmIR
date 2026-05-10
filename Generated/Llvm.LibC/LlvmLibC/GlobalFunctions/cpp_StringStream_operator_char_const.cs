using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStreamlsEPKc")]
[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::operator<<(char const*)")]
internal static partial class cpp_StringStream_operator_char_const
{
	public unsafe static void* Invoke(void* @this, void* str)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view_string_view_char_const.Invoke(&cpp_string_view2, str);
		return unchecked(cpp_StringStream_operator_cpp_string_view.Invoke(@this, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]));
	}
}
