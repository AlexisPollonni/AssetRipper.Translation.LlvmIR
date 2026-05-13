using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetIDv16_hE5blockEPNS_3cpp4byteEh")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memset<unsigned char vector[16]>::block(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
internal static partial class generic_Memset_unsigned_char_vector_16_block_cpp_byte_unsigned_char
{
	public unsafe static void Invoke(void* dst, sbyte value)
	{
		void_generic_store_unsigned_char_vector_16_cpp_byte_unsigned_char_vector_16.Invoke(dst, unsigned_char_vector_16_generic_splat_unsigned_char_vector_16_unsigned_char.Invoke(value));
	}
}
