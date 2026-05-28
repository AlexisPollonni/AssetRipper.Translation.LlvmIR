using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_cmp_neq_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7cmp_neqImEENS_18StrictIntegralTypeIiEEPKNS_3cpp4byteES7_m")]
	[DemangledName("__llvm_libc_20_1_2_::StrictIntegralType<int> __llvm_libc_20_1_2_::generic::cmp_neq<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrictIntegralType<int>")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		long a = 0L;
		long b = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &a);
		a = Generic_load_be_unsigned_long.Invoke(P1, Offset);
		Llvm_lifetime_start_p0.Invoke(8L, &b);
		b = Generic_load_be_unsigned_long.Invoke(P2, Offset);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Cmp_neq_uint64_t.Invoke(a, b);
		Llvm_lifetime_end_p0.Invoke(8L, &b);
		Llvm_lifetime_end_p0.Invoke(8L, &a);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
	}
}
