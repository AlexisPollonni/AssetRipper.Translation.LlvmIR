using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeIhEEvPNS_3cpp4byteET_")]
[DemangledName("void __llvm_libc_20_1_2_::generic::store<unsigned char>(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
internal static partial class void_generic_store_unsigned_char_cpp_byte_unsigned_char
{
	public unsafe static void Invoke(void* dst, sbyte value)
	{
		void_store_unsigned_char_cpp_byte_unsigned_char.Invoke(dst, value);
	}
}
