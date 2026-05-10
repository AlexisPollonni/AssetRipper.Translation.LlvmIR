using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIDv16_hLm4EEEE9head_tailEPNS2_4byteEPKS7_m")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class generic_Memmove_cpp_array_unsigned_char_vector_16_4ul_head_tail_cpp_byte_cpp_byte_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long count)
	{
		long num = 0L;
		cpp_array_2b9gdz cpp_array_2b9gdz2 = default(cpp_array_2b9gdz);
		cpp_array_2b9gdz cpp_array_2b9gdz3 = default(cpp_array_2b9gdz);
		cpp_array_2b9gdz cpp_array_2b9gdz4 = default(cpp_array_2b9gdz);
		cpp_array_2b9gdz cpp_array_2b9gdz5 = default(cpp_array_2b9gdz);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = count - 64L;
			llvm_lifetime_start_p0.Invoke(64L, &cpp_array_2b9gdz2);
			llvm_memset_p0_i64.Invoke(&cpp_array_2b9gdz2, -86, 64L, isVolatile: false);
			cpp_array_unsigned_char_vector_16_4ul_generic_load_cpp_array_unsigned_char_vector_16_4ul_cpp_byte_const.Invoke(&cpp_array_2b9gdz2, src);
			llvm_lifetime_start_p0.Invoke(64L, &cpp_array_2b9gdz3);
			llvm_memset_p0_i64.Invoke(&cpp_array_2b9gdz3, -86, 64L, isVolatile: false);
			cpp_array_unsigned_char_vector_16_4ul_generic_load_cpp_array_unsigned_char_vector_16_4ul_cpp_byte_const.Invoke(&cpp_array_2b9gdz3, (byte*)src + num);
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_2b9gdz4, &cpp_array_2b9gdz2, 64L, isVolatile: false);
			void_generic_store_cpp_array_unsigned_char_vector_16_4ul_cpp_byte_cpp_array_unsigned_char_vector_16_4ul.Invoke(dst, &cpp_array_2b9gdz4);
			byte* dst2 = (byte*)dst + num;
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_2b9gdz5, &cpp_array_2b9gdz3, 64L, isVolatile: false);
			void_generic_store_cpp_array_unsigned_char_vector_16_4ul_cpp_byte_cpp_array_unsigned_char_vector_16_4ul.Invoke(dst2, &cpp_array_2b9gdz5);
			llvm_lifetime_end_p0.Invoke(64L, &cpp_array_2b9gdz3);
			llvm_lifetime_end_p0.Invoke(64L, &cpp_array_2b9gdz2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
