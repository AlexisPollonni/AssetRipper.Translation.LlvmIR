using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic14MemcmpSequenceItJEE5blockEPKNS_3cpp4byteES6_")]
[DemangledName("__llvm_libc_20_1_2_::generic::MemcmpSequence<unsigned short>::block(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class generic_MemcmpSequence_unsigned_short_block_cpp_byte_const_cpp_byte_const
{
	public unsafe static int Invoke(void* p1, void* p2)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		*unchecked((int*)(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2)) = -1431655766;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = StrictIntegralType_int_generic_cmp_unsigned_short_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, 0L);
		if (!StrictIntegralType_int_operator_bool_const.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2))
		{
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = StrictIntegralType_int_zero.Invoke();
		}
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
