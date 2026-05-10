using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic4BcmpIhE5blockEPKNS_3cpp4byteES6_")]
[DemangledName("__llvm_libc_20_1_2_::generic::Bcmp<unsigned char>::block(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class generic_Bcmp_unsigned_char_block_cpp_byte_const_cpp_byte_const
{
	public unsafe static int Invoke(void* p1, void* p2)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		StrictIntegralType_unsigned_int_StrictIntegralType_unsigned_int_false_unsigned_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, unsigned_int_generic_neq_unsigned_char_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, 0L));
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
