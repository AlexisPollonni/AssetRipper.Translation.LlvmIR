using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_bcmp
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11inline_bcmpEPKvS1_m")]
	[DemangledName("__llvm_libc_20_1_2_::inline_bcmp(void const*, void const*, unsigned long)")]
	public unsafe static int Invoke([NativeType("void const*")] void* p1, [NativeType("void const*")] void* p2, [NativeType("unsigned long")] long count)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = inline_bcmp_x86.Invoke(p1, p2, count);
		int result = StrictIntegralType_unsigned_int_ToInt32.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
		return result;
	}
}
