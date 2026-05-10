using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_17inline_memcmp_x86EPKNS_3cpp4byteES3_m")]
[DemangledName("__llvm_libc_20_1_2_::inline_memcmp_x86(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class inline_memcmp_x86_cpp_byte_const_cpp_byte_const_unsigned_long
{
	public unsafe static int Invoke(void* p1, void* p2, long count)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		switch (count)
		{
		case 0L:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = StrictIntegralType_int_zero.Invoke();
			break;
		case 1L:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_Memcmp_unsigned_char_block_cpp_byte_const_cpp_byte_const.Invoke(p1, p2);
			break;
		case 2L:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_Memcmp_unsigned_short_block_cpp_byte_const_cpp_byte_const.Invoke(p1, p2);
			break;
		case 3L:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_MemcmpSequence_unsigned_short_unsigned_char_block_cpp_byte_const_cpp_byte_const.Invoke(p1, p2);
			break;
		case 4L:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_Memcmp_unsigned_int_block_cpp_byte_const_cpp_byte_const.Invoke(p1, p2);
			break;
		case 5L:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_MemcmpSequence_unsigned_int_unsigned_char_block_cpp_byte_const_cpp_byte_const.Invoke(p1, p2);
			break;
		case 6L:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_MemcmpSequence_unsigned_int_unsigned_short_block_cpp_byte_const_cpp_byte_const.Invoke(p1, p2);
			break;
		case 7L:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_Memcmp_unsigned_int_head_tail_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, 7L);
			break;
		case 8L:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_Memcmp_unsigned_long_block_cpp_byte_const_cpp_byte_const.Invoke(p1, p2);
			break;
		case 9L:
		case 10L:
		case 11L:
		case 12L:
		case 13L:
		case 14L:
		case 15L:
		case 16L:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_Memcmp_unsigned_long_head_tail_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, count);
			break;
		default:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = inline_memcmp_generic_gt16_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, count);
			break;
		}
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
