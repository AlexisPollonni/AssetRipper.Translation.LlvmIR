using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetImE9head_tailEPNS_3cpp4byteEhm")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memset<unsigned long>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long)")]
internal static partial class generic_Memset_unsigned_long_head_tail_cpp_byte_unsigned_char_unsigned_long
{
	public unsafe static void Invoke(void* dst, sbyte value, long count)
	{
		sbyte value2 = value;
		generic_Memset_unsigned_long_block_cpp_byte_unsigned_char.Invoke(dst, value2);
		generic_Memset_unsigned_long_tail_cpp_byte_unsigned_char_unsigned_long.Invoke(dst, value2, count);
	}
}
