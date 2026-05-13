using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetINS_3cpp5arrayIDv16_hLm2EEEE20loop_and_tail_offsetEPNS2_4byteEhmm")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memset<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>::loop_and_tail_offset(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long, unsigned long)")]
internal static partial class generic_Memset_cpp_array_unsigned_char_vector_16_2ul_loop_and_tail_offset_cpp_byte_unsigned_char_unsigned_long_unsigned_long
{
	public unsafe static void Invoke(void* dst, sbyte value, long count, long offset)
	{
		sbyte value2 = value;
		long num = offset;
		unchecked
		{
			do
			{
				generic_Memset_cpp_array_unsigned_char_vector_16_2ul_block_cpp_byte_unsigned_char.Invoke((byte*)dst + num, value2);
				num += 32L;
			}
			while ((ulong)num < (ulong)(count - 32L));
			generic_Memset_cpp_array_unsigned_char_vector_16_2ul_tail_cpp_byte_unsigned_char_unsigned_long.Invoke(dst, value2, count);
		}
	}
}
