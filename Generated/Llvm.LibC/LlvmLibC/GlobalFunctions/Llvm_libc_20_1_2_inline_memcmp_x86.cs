using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_inline_memcmp_x86
{
	[MangledName("_ZN19__llvm_libc_20_1_2_17inline_memcmp_x86EPKNS_3cpp4byteES3_m")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memcmp_x86(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		switch (Count)
		{
		case 0L:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = StrictIntegralType_int_zero.Invoke();
			break;
		case 1L:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Memcmp_unsigned_char_block.Invoke(P1, P2);
			break;
		case 2L:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Memcmp_unsigned_short_block.Invoke(P1, P2);
			break;
		case 3L:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = MemcmpSequence_unsigned_short_unsigned_char_block.Invoke(P1, P2);
			break;
		case 4L:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Memcmp_unsigned_int_block.Invoke(P1, P2);
			break;
		case 5L:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = MemcmpSequence_unsigned_int_unsigned_char_block.Invoke(P1, P2);
			break;
		case 6L:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = MemcmpSequence_unsigned_int_unsigned_short_block.Invoke(P1, P2);
			break;
		case 7L:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Memcmp_unsigned_int_head_tail.Invoke(P1, P2, 7L);
			break;
		case 8L:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Memcmp_unsigned_long_block.Invoke(P1, P2);
			break;
		case 9L:
		case 10L:
		case 11L:
		case 12L:
		case 13L:
		case 14L:
		case 15L:
		case 16L:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Memcmp_unsigned_long_head_tail.Invoke(P1, P2, Count);
			break;
		default:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Llvm_libc_20_1_2_inline_memcmp_generic_gt16.Invoke(P1, P2, Count);
			break;
		}
		return llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
	}
}
