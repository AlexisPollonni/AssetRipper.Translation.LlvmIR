using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetINS_3cpp5arrayIDv16_hLm4EEEE4tailEPNS2_4byteEhm")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memset<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>::tail(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long)")]
internal static partial class generic_Memset_cpp_array_unsigned_char_vector_16_4ul_tail_cpp_byte_unsigned_char_unsigned_long
{
	public unsafe static void Invoke(void* dst, sbyte value, long count)
	{
		generic_Memset_cpp_array_unsigned_char_vector_16_4ul_block_cpp_byte_unsigned_char.Invoke(unchecked((byte*)dst) + count + -64, value);
	}
}
