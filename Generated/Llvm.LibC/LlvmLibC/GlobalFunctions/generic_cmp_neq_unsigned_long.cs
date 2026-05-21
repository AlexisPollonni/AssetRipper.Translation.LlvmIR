using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_cmp_neq_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7cmp_neqImEENS_18StrictIntegralTypeIiEEPKNS_3cpp4byteES7_m")]
	[DemangledName("__llvm_libc_20_1_2_::StrictIntegralType<int> __llvm_libc_20_1_2_::generic::cmp_neq<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrictIntegralType<int>")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p2, [NativeType("unsigned long")] long offset)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		long a = 0L;
		long b = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &a);
		a = generic_load_be_unsigned_long.Invoke(p1, offset);
		llvm_lifetime_start_p0.Invoke(8L, &b);
		b = generic_load_be_unsigned_long.Invoke(p2, offset);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = cmp_neq_uint64_t.Invoke(a, b);
		llvm_lifetime_end_p0.Invoke(8L, &b);
		llvm_lifetime_end_p0.Invoke(8L, &a);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
