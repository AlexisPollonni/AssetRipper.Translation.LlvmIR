using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Inline_memcmp
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13inline_memcmpEPKvS1_m")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memcmp(void const*, void const*, unsigned long)")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("void const*")] void* P1, [MangledName("p2")][NativeType("void const*")] void* P2, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Inline_memcmp_x86.Invoke(P1, P2, Count);
		int result = StrictIntegralType_int_ToInt32.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		return result;
	}
}
