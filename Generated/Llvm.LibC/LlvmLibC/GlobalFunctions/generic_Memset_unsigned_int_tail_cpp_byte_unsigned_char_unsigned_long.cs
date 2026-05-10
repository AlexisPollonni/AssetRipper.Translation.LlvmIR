using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetIjE4tailEPNS_3cpp4byteEhm")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memset<unsigned int>::tail(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long)")]
internal static partial class generic_Memset_unsigned_int_tail_cpp_byte_unsigned_char_unsigned_long
{
	public unsafe static void Invoke(void* dst, sbyte value, long count)
	{
		generic_Memset_unsigned_int_block_cpp_byte_unsigned_char.Invoke(unchecked((byte*)dst) + count + -4, value);
	}
}
