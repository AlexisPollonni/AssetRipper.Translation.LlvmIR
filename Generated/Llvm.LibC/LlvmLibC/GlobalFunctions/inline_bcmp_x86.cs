using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_bcmp_x86
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15inline_bcmp_x86EPKNS_3cpp4byteES3_m")]
	[DemangledName("__llvm_libc_20_1_2_::inline_bcmp_x86(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p2, [NativeType("unsigned long")] long count)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		switch (count)
		{
		case 0L:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = StrictIntegralType_unsigned_int_zero.Invoke();
			break;
		case 1L:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = Bcmp_unsigned_char_block.Invoke(p1, p2);
			break;
		case 2L:
		case 3L:
		case 4L:
			StrictIntegralType_unsigned_int_StrictIntegralType_unsigned_int_false.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, generic_branchless_head_tail_neq_unsigned_short.Invoke(p1, p2, count));
			break;
		case 5L:
		case 6L:
		case 7L:
		case 8L:
			StrictIntegralType_unsigned_int_StrictIntegralType_unsigned_int_false.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, generic_branchless_head_tail_neq_unsigned_int.Invoke(p1, p2, count));
			break;
		case 9L:
		case 10L:
		case 11L:
		case 12L:
		case 13L:
		case 14L:
		case 15L:
		case 16L:
			StrictIntegralType_unsigned_int_StrictIntegralType_unsigned_int_false.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, generic_branchless_head_tail_neq_unsigned_long.Invoke(p1, p2, count));
			break;
		default:
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = inline_bcmp_generic_gt16.Invoke(p1, p2, count);
			break;
		}
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
