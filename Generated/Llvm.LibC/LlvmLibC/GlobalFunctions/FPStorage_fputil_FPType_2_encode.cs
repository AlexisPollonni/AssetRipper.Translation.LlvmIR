using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_2_encode
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE6encodeENS4_11SignificandE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand)")]
	public unsafe static long Invoke([MangledName("value.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand")] long Value)
	{
		Fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg = new Fputil_internal_FPRepSem_fq8nhg
		{
			FPStorage = 
			{
				Val = Value
			}
		};
		return TypedInt_unsigned_long_to_storage_type.Invoke(&fputil_internal_FPRepSem_fq8nhg) & 0xFFFFFFFFFFFFFL;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE6encodeENS4_14BiasedExponentE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent)")]
	public unsafe static long Invoke([MangledName("exp.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent")] int Exp)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = new Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent
		{
			field_0 = 
			{
				field_0 = Exp
			}
		};
		return (TypedInt_unsigned_int_to_storage_type_y53az8.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent) << 52) & 0x7FF0000000000000L;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE6encodeENS4_14BiasedExponentENS4_11SignificandE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand)")]
	public unsafe static long Invoke([MangledName("exp.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent")] int Exp, [MangledName("sig.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand")] long Sig)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg = default(Fputil_internal_FPRepSem_fq8nhg);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = default(Fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0 = Exp;
		fputil_internal_FPRepSem_fq8nhg.FPStorage.Val = Sig;
		Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, 4L, isVolatile: false);
		long num = Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
		Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_fq8nhg2, &fputil_internal_FPRepSem_fq8nhg, 8L, isVolatile: false);
		return num | Invoke(fputil_internal_FPRepSem_fq8nhg2.FPStorage.Val);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE6encodeENS_4SignENS4_14BiasedExponentENS4_11SignificandE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::encode(__llvm_libc_20_1_2_::Sign, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand)")]
	public unsafe static long Invoke([MangledName("sign.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte Sign, [MangledName("exp.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::BiasedExponent")] int Exp, [MangledName("sig.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand")] long Sig)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg = default(Fputil_internal_FPRepSem_fq8nhg);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = default(Fputil_internal_FPRepSem_fq8nhg);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg3 = default(Fputil_internal_FPRepSem_fq8nhg);
		anon_izyfb.Val = Sign;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0 = Exp;
		fputil_internal_FPRepSem_fq8nhg.FPStorage.Val = Sig;
		if (Sign_is_neg.Invoke(&anon_izyfb))
		{
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, 4L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_fq8nhg2, &fputil_internal_FPRepSem_fq8nhg, 8L, isVolatile: false);
			return long.MinValue | Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0, fputil_internal_FPRepSem_fq8nhg2.FPStorage.Val);
		}
		Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, 4L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_fq8nhg3, &fputil_internal_FPRepSem_fq8nhg, 8L, isVolatile: false);
		return Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0, fputil_internal_FPRepSem_fq8nhg3.FPStorage.Val);
	}
}
