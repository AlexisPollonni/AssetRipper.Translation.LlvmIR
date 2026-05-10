using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadIhEET_PKNS_3cpp4byteE")]
[DemangledName("unsigned char __llvm_libc_20_1_2_::generic::load<unsigned char>(__llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class unsigned_char_generic_load_unsigned_char_cpp_byte_const
{
	public unsafe static sbyte Invoke(void* src)
	{
		return unsigned_char_load_unsigned_char_cpp_byte_const.Invoke(src);
	}
}
