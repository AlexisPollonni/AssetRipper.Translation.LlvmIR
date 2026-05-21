using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_cpp_array_unsigned_char_vector_16_2ul_loop_and_tail_offset
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetINS_3cpp5arrayIDv16_hLm2EEEE20loop_and_tail_offsetEPNS2_4byteEhmm")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memset<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>::loop_and_tail_offset(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long, unsigned long)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("unsigned char")] sbyte value, [NativeType("unsigned long")] long count, [NativeType("unsigned long")] long offset)
	{
		sbyte value2 = value;
		long num = offset;
		unchecked
		{
			do
			{
				Memset_cpp_array_unsigned_char_vector_16_2ul_block.Invoke((byte*)dst + num, value2);
				num += 32L;
			}
			while ((ulong)num < (ulong)(count - 32L));
			Memset_cpp_array_unsigned_char_vector_16_2ul_tail.Invoke(dst, value2, count);
		}
	}
}
