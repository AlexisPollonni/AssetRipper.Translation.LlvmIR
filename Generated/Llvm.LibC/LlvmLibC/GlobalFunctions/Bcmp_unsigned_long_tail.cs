using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bcmp_unsigned_long_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4BcmpImE4tailEPKNS_3cpp4byteES6_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Bcmp<unsigned long>::tail(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		long offset = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &offset);
		offset = unchecked(Count - 8L);
		StrictIntegralType_unsigned_int_StrictIntegralType_unsigned_int_false.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, Generic_neq_unsigned_long.Invoke(P1, P2, offset));
		Llvm_lifetime_end_p0.Invoke(8L, &offset);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
	}
}
