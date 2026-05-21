using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_inline_bcmp_x86
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15inline_bcmp_x86EPKNS_3cpp4byteES3_m")]
	[DemangledName("__llvm_libc_20_1_2_::inline_bcmp_x86(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		switch (Count)
		{
		case 0L:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = StrictIntegralType_unsigned_int_zero.Invoke();
			break;
		case 1L:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Bcmp_unsigned_char_block.Invoke(P1, P2);
			break;
		case 2L:
		case 3L:
		case 4L:
			StrictIntegralType_unsigned_int_StrictIntegralType_unsigned_int_false.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, Generic_branchless_head_tail_neq_unsigned_short.Invoke(P1, P2, Count));
			break;
		case 5L:
		case 6L:
		case 7L:
		case 8L:
			StrictIntegralType_unsigned_int_StrictIntegralType_unsigned_int_false.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, Generic_branchless_head_tail_neq_unsigned_int.Invoke(P1, P2, Count));
			break;
		case 9L:
		case 10L:
		case 11L:
		case 12L:
		case 13L:
		case 14L:
		case 15L:
		case 16L:
			StrictIntegralType_unsigned_int_StrictIntegralType_unsigned_int_false.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, Generic_branchless_head_tail_neq_unsigned_long.Invoke(P1, P2, Count));
			break;
		default:
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Llvm_libc_20_1_2_inline_bcmp_generic_gt16.Invoke(P1, P2, Count);
			break;
		}
		return llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
	}
}
