using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcmp_unsigned_long_block_offset
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemcmpImE12block_offsetEPKNS_3cpp4byteES6_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memcmp<unsigned long>::block_offset(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p2, [NativeType("unsigned long")] long offset)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		if (!generic_eq_unsigned_long.Invoke(p1, p2, offset))
		{
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_cmp_neq_unsigned_long.Invoke(p1, p2, offset);
		}
		else
		{
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = StrictIntegralType_int_zero.Invoke();
		}
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
