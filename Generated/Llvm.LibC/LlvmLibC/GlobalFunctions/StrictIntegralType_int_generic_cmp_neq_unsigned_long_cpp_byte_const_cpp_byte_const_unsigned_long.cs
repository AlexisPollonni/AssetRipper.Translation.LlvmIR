using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic7cmp_neqImEENS_18StrictIntegralTypeIiEEPKNS_3cpp4byteES7_m")]
[DemangledName("__llvm_libc_20_1_2_::StrictIntegralType<int> __llvm_libc_20_1_2_::generic::cmp_neq<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class StrictIntegralType_int_generic_cmp_neq_unsigned_long_cpp_byte_const_cpp_byte_const_unsigned_long
{
	public unsafe static int Invoke(void* p1, void* p2, long offset)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		long a = 0L;
		long b = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &a);
		a = unsigned_long_generic_load_be_unsigned_long_cpp_byte_const_unsigned_long.Invoke(p1, offset);
		llvm_lifetime_start_p0.Invoke(8L, &b);
		b = unsigned_long_generic_load_be_unsigned_long_cpp_byte_const_unsigned_long.Invoke(p2, offset);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = cmp_neq_uint64_t_unsigned_long_unsigned_long.Invoke(a, b);
		llvm_lifetime_end_p0.Invoke(8L, &b);
		llvm_lifetime_end_p0.Invoke(8L, &a);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
