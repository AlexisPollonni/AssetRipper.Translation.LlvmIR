using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetItE5blockEPNS_3cpp4byteEh")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memset<unsigned short>::block(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
internal static partial class generic_Memset_unsigned_short_block_cpp_byte_unsigned_char
{
	public unsafe static void Invoke(void* dst, sbyte value)
	{
		void_generic_store_unsigned_short_cpp_byte_unsigned_short.Invoke(dst, unsigned_short_generic_splat_unsigned_short_unsigned_char.Invoke(value));
	}
}
