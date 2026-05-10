using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE19set_biased_exponentENS4_14BiasedExponentE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::set_biased_exponent(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::BiasedExponent)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_0_set_biased_exponent_fputil_internal_FPStorage_fputil_FPType_0_BiasedExponent
{
	public unsafe static void Invoke(void* @this, [MangledName("biased.coerce")] int biased)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = biased;
		unchecked
		{
			short field_ = ((fputil_internal_FPStorage_za9n4f*)@this)->field_0;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, 4L, isVolatile: false);
			((fputil_internal_FPStorage_za9n4f*)@this)->field_0 = fputil_internal_FPStorage_fputil_FPType_0_merge_unsigned_short_unsigned_short_unsigned_short.Invoke(field_, fputil_internal_FPStorage_fputil_FPType_0_encode_fputil_internal_FPStorage_fputil_FPType_0_BiasedExponent.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0), 31744);
		}
	}
}
