using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Inline_memset_x86_ce59gu
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L17inline_memset_x86EPNS_3cpp4byteEhm.209")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memset_x86(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long) (.209)")]
	[CleanName("Inline_memset_x86")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("value")][NativeType("unsigned char")] sbyte Value, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		void* dst = null;
		long num = 0L;
		dst = Dst;
		sbyte value = Value;
		num = Count;
		switch (num)
		{
		case 0L:
			return;
		case 1L:
			Memset_unsigned_char_block.Invoke(dst, value);
			return;
		case 2L:
			Memset_unsigned_short_block.Invoke(dst, value);
			return;
		case 3L:
			MemsetSequence_unsigned_short_unsigned_char_block.Invoke(dst, value);
			return;
		case 4L:
		case 5L:
		case 6L:
		case 7L:
		case 8L:
			Memset_unsigned_int_head_tail.Invoke(dst, value, num);
			return;
		case 9L:
		case 10L:
		case 11L:
		case 12L:
		case 13L:
		case 14L:
		case 15L:
		case 16L:
			Memset_unsigned_long_head_tail.Invoke(dst, value, num);
			return;
		case 17L:
		case 18L:
		case 19L:
		case 20L:
		case 21L:
		case 22L:
		case 23L:
		case 24L:
		case 25L:
		case 26L:
		case 27L:
		case 28L:
		case 29L:
		case 30L:
		case 31L:
		case 32L:
			Memset_unsigned_char_vector_16_head_tail.Invoke(dst, value, num);
			return;
		case 33L:
		case 34L:
		case 35L:
		case 36L:
		case 37L:
		case 38L:
		case 39L:
		case 40L:
		case 41L:
		case 42L:
		case 43L:
		case 44L:
		case 45L:
		case 46L:
		case 47L:
		case 48L:
		case 49L:
		case 50L:
		case 51L:
		case 52L:
		case 53L:
		case 54L:
		case 55L:
		case 56L:
		case 57L:
		case 58L:
		case 59L:
		case 60L:
		case 61L:
		case 62L:
		case 63L:
		case 64L:
			Memset_cpp_array_unsigned_char_vector_16_2ul_head_tail.Invoke(dst, value, num);
			return;
		case 65L:
		case 66L:
		case 67L:
		case 68L:
		case 69L:
		case 70L:
		case 71L:
		case 72L:
		case 73L:
		case 74L:
		case 75L:
		case 76L:
		case 77L:
		case 78L:
		case 79L:
		case 80L:
		case 81L:
		case 82L:
		case 83L:
		case 84L:
		case 85L:
		case 86L:
		case 87L:
		case 88L:
		case 89L:
		case 90L:
		case 91L:
		case 92L:
		case 93L:
		case 94L:
		case 95L:
		case 96L:
		case 97L:
		case 98L:
		case 99L:
		case 100L:
		case 101L:
		case 102L:
		case 103L:
		case 104L:
		case 105L:
		case 106L:
		case 107L:
		case 108L:
		case 109L:
		case 110L:
		case 111L:
		case 112L:
		case 113L:
		case 114L:
		case 115L:
		case 116L:
		case 117L:
		case 118L:
		case 119L:
		case 120L:
		case 121L:
		case 122L:
		case 123L:
		case 124L:
		case 125L:
		case 126L:
		case 127L:
		case 128L:
			Memset_cpp_array_unsigned_char_vector_16_4ul_head_tail.Invoke(dst, value, num);
			return;
		}
		Memset_cpp_array_unsigned_char_vector_16_2ul_block.Invoke(dst, value);
		Align_to_next_boundary_32ul_cpp_byte.Invoke(&dst, &num);
		Memset_cpp_array_unsigned_char_vector_16_2ul_loop_and_tail.Invoke(dst, value, num);
	}
}
