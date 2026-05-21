using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_2_set_biased_exponent
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE19set_biased_exponentENS4_14BiasedExponentE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::set_biased_exponent(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent)")]
	public unsafe static void Invoke(void* @this, [MangledName("biased.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent")] int biased)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = biased;
		unchecked
		{
			long val = ((fputil_internal_FPStorage_v3nexn*)@this)->val;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, 4L, isVolatile: false);
			((fputil_internal_FPStorage_v3nexn*)@this)->val = FPStorage_fputil_FPType_2_merge.Invoke(val, FPStorage_fputil_FPType_2_encode.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0), 9218868437227405312L);
		}
	}
}
