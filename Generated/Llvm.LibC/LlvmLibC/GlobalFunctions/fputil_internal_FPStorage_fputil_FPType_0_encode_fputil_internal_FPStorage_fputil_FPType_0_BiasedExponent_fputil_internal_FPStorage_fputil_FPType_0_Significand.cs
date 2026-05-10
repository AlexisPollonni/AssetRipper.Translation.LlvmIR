using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE6encodeENS4_14BiasedExponentENS4_11SignificandE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::BiasedExponent, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_0_encode_fputil_internal_FPStorage_fputil_FPType_0_BiasedExponent_fputil_internal_FPStorage_fputil_FPType_0_Significand
{
	public unsafe static short Invoke([MangledName("exp.coerce")] int exp, [MangledName("sig.coerce")] short sig)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h2 = default(fputil_internal_FPRepSem_i7nz4h);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h3 = default(fputil_internal_FPRepSem_i7nz4h);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = exp;
		fputil_internal_FPRepSem_i7nz4h2.FPStorage.field_0 = sig;
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, 4L, isVolatile: false);
		unchecked
		{
			ushort num = (ushort)fputil_internal_FPStorage_fputil_FPType_0_encode_fputil_internal_FPStorage_fputil_FPType_0_BiasedExponent.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_i7nz4h3, &fputil_internal_FPRepSem_i7nz4h2, 2L, isVolatile: false);
			return (short)(num | (ushort)fputil_internal_FPStorage_fputil_FPType_0_encode_fputil_internal_FPStorage_fputil_FPType_0_Significand.Invoke(fputil_internal_FPRepSem_i7nz4h3.FPStorage.field_0));
		}
	}
}
