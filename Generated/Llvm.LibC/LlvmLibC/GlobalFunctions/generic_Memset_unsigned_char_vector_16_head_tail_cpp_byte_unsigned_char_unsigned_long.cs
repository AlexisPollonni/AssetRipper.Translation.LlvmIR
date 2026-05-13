using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetIDv16_hE9head_tailEPNS_3cpp4byteEhm")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memset<unsigned char vector[16]>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long)")]
internal static partial class generic_Memset_unsigned_char_vector_16_head_tail_cpp_byte_unsigned_char_unsigned_long
{
	public unsafe static void Invoke(void* dst, sbyte value, long count)
	{
		sbyte value2 = value;
		generic_Memset_unsigned_char_vector_16_block_cpp_byte_unsigned_char.Invoke(dst, value2);
		generic_Memset_unsigned_char_vector_16_tail_cpp_byte_unsigned_char_unsigned_long.Invoke(dst, value2, count);
	}
}
