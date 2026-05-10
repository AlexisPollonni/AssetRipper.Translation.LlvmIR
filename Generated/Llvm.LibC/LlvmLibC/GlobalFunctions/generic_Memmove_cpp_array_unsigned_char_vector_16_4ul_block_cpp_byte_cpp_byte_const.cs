using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIDv16_hLm4EEEE5blockEPNS2_4byteEPKS7_")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>::block(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class generic_Memmove_cpp_array_unsigned_char_vector_16_4ul_block_cpp_byte_cpp_byte_const
{
	public unsafe static void Invoke(void* dst, void* src)
	{
		cpp_array_2b9gdz cpp_array_2b9gdz2 = default(cpp_array_2b9gdz);
		cpp_array_unsigned_char_vector_16_4ul_generic_load_cpp_array_unsigned_char_vector_16_4ul_cpp_byte_const.Invoke(&cpp_array_2b9gdz2, src);
		void_generic_store_cpp_array_unsigned_char_vector_16_4ul_cpp_byte_cpp_array_unsigned_char_vector_16_4ul.Invoke(dst, &cpp_array_2b9gdz2);
	}
}
