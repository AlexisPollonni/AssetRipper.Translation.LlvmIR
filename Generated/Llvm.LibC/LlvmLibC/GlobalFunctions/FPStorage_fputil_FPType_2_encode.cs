using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_2_encode
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE6encodeENS4_11SignificandE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand)")]
	public unsafe static long Invoke([MangledName("value.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand")] long value)
	{
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = new fputil_internal_FPRepSem_fq8nhg
		{
			FPStorage = 
			{
				val = value
			}
		};
		return TypedInt_unsigned_long_to_storage_type.Invoke(&fputil_internal_FPRepSem_fq8nhg2) & 0xFFFFFFFFFFFFFL;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE6encodeENS4_14BiasedExponentE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent)")]
	public unsafe static long Invoke([MangledName("exp.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent")] int exp)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = new fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent
		{
			field_0 = 
			{
				field_0 = exp
			}
		};
		return (TypedInt_unsigned_int_to_storage_type_y53az8.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2) << 52) & 0x7FF0000000000000L;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE6encodeENS4_14BiasedExponentENS4_11SignificandE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand)")]
	public unsafe static long Invoke([MangledName("exp.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent")] int exp, [MangledName("sig.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand")] long sig)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg3 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = exp;
		fputil_internal_FPRepSem_fq8nhg2.FPStorage.val = sig;
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, 4L, isVolatile: false);
		long num = Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0);
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_fq8nhg3, &fputil_internal_FPRepSem_fq8nhg2, 8L, isVolatile: false);
		return num | Invoke(fputil_internal_FPRepSem_fq8nhg3.FPStorage.val);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE6encodeENS_4SignENS4_14BiasedExponentENS4_11SignificandE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::encode(__llvm_libc_20_1_2_::Sign, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand)")]
	public unsafe static long Invoke([MangledName("sign.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte sign, [MangledName("exp.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent")] int exp, [MangledName("sig.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand")] long sig)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg3 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg4 = default(fputil_internal_FPRepSem_fq8nhg);
		anon_izyfb8.val = sign;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = exp;
		fputil_internal_FPRepSem_fq8nhg2.FPStorage.val = sig;
		if (Sign_is_neg.Invoke(&anon_izyfb8))
		{
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, 4L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_fq8nhg3, &fputil_internal_FPRepSem_fq8nhg2, 8L, isVolatile: false);
			return long.MinValue | Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0, fputil_internal_FPRepSem_fq8nhg3.FPStorage.val);
		}
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, 4L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_fq8nhg4, &fputil_internal_FPRepSem_fq8nhg2, 8L, isVolatile: false);
		return Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4.field_0.field_0, fputil_internal_FPRepSem_fq8nhg4.FPStorage.val);
	}
}
