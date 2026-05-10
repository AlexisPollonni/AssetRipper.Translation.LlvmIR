using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStreamlsEc")]
[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::operator<<(char)")]
internal static partial class cpp_StringStream_operator_char
{
	public unsafe static void* Invoke(void* @this, sbyte a)
	{
		sbyte b = a;
		cpp_StringStream_write_char_const_unsigned_long.Invoke(@this, &b, 1L);
		return @this;
	}
}
