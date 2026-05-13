using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemcmpIjE9head_tailEPKNS_3cpp4byteES6_m")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memcmp<unsigned int>::head_tail(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class generic_Memcmp_unsigned_int_head_tail_cpp_byte_const_cpp_byte_const_unsigned_long
{
	public unsafe static int Invoke(void* p1, void* p2, long count)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		*unchecked((int*)(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2)) = -1431655766;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = StrictIntegralType_int_generic_cmp_unsigned_int_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, 0L);
		if (!StrictIntegralType_int_operator_bool_const.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2))
		{
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_Memcmp_unsigned_int_tail_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, count);
		}
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
