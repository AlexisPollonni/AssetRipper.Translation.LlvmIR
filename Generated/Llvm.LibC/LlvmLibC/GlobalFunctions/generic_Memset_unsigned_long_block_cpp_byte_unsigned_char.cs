using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetImE5blockEPNS_3cpp4byteEh")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memset<unsigned long>::block(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
internal static partial class generic_Memset_unsigned_long_block_cpp_byte_unsigned_char
{
	public unsafe static void Invoke(void* dst, sbyte value)
	{
		void_generic_store_unsigned_long_cpp_byte_unsigned_long.Invoke(dst, unsigned_long_generic_splat_unsigned_long_unsigned_char.Invoke(value));
	}
}
