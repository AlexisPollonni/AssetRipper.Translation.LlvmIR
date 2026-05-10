using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIDv16_hLm4EEEE21loop_and_tail_forwardEPNS2_4byteEPKS7_m")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>::loop_and_tail_forward(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class generic_Memmove_cpp_array_unsigned_char_vector_16_4ul_loop_and_tail_forward_cpp_byte_cpp_byte_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long count)
	{
		long num = 0L;
		cpp_array_2b9gdz cpp_array_2b9gdz2 = default(cpp_array_2b9gdz);
		long num2 = 0L;
		cpp_array_2b9gdz cpp_array_2b9gdz3 = default(cpp_array_2b9gdz);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = count - 64L;
			llvm_lifetime_start_p0.Invoke(64L, &cpp_array_2b9gdz2);
			llvm_memset_p0_i64.Invoke(&cpp_array_2b9gdz2, -86, 64L, isVolatile: false);
			cpp_array_unsigned_char_vector_16_4ul_generic_load_cpp_array_unsigned_char_vector_16_4ul_cpp_byte_const.Invoke(&cpp_array_2b9gdz2, (byte*)src + num);
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 0L;
			do
			{
				generic_Memmove_cpp_array_unsigned_char_vector_16_4ul_block_cpp_byte_cpp_byte_const.Invoke((byte*)dst + num2, (byte*)src + num2);
				num2 += 64L;
			}
			while ((ulong)num2 < (ulong)(count - 64L));
			byte* dst2 = (byte*)dst + num;
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_2b9gdz3, &cpp_array_2b9gdz2, 64L, isVolatile: false);
			void_generic_store_cpp_array_unsigned_char_vector_16_4ul_cpp_byte_cpp_array_unsigned_char_vector_16_4ul.Invoke(dst2, &cpp_array_2b9gdz3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(64L, &cpp_array_2b9gdz2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
