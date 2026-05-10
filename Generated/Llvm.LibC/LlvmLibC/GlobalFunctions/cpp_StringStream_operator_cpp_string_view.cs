using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStreamlsENS0_11string_viewE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::operator<<(__llvm_libc_20_1_2_::cpp::string_view)")]
internal static partial class cpp_StringStream_operator_cpp_string_view
{
	public unsafe static void* Invoke(void* @this, [MangledName("str.coerce0")] void* str, [MangledName("str.coerce1")] long str_coerce1)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view2) = str;
			((long*)(&cpp_string_view2))[1] = str_coerce1;
			cpp_StringStream_write_char_const_unsigned_long.Invoke(@this, cpp_string_view_data_const.Invoke(&cpp_string_view2), cpp_string_view_size_const.Invoke(&cpp_string_view2));
			return @this;
		}
	}
}
