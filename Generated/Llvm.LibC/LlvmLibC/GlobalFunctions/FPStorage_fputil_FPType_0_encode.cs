using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_0_encode
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE6encodeENS4_11SignificandE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand)")]
	public unsafe static short Invoke([MangledName("value.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand")] short Value)
	{
		Fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h = new Fputil_internal_FPRepSem_i7nz4h
		{
			FPStorage = 
			{
				field_0 = Value
			}
		};
		return unchecked((short)((ushort)TypedInt_unsigned_short_to_storage_type.Invoke(&fputil_internal_FPRepSem_i7nz4h) & 0x3FF));
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE6encodeENS4_14BiasedExponentE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::BiasedExponent)")]
	public unsafe static short Invoke([MangledName("exp.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::BiasedExponent")] int Exp)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = new Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent
		{
			field_0 = 
			{
				field_0 = Exp
			}
		};
		return unchecked((short)(((ushort)TypedInt_unsigned_int_to_storage_type_wwhq92.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent) << 10) & 0x7C00));
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE6encodeENS4_14BiasedExponentENS4_11SignificandE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::BiasedExponent, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand)")]
	public unsafe static short Invoke([MangledName("exp.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::BiasedExponent")] int Exp, [MangledName("sig.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand")] short Sig)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h = default(Fputil_internal_FPRepSem_i7nz4h);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h2 = default(Fputil_internal_FPRepSem_i7nz4h);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0 = Exp;
		fputil_internal_FPRepSem_i7nz4h.FPStorage.field_0 = Sig;
		Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, 4L, isVolatile: false);
		unchecked
		{
			ushort num = (ushort)Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_i7nz4h2, &fputil_internal_FPRepSem_i7nz4h, 2L, isVolatile: false);
			return (short)(num | (ushort)Invoke(fputil_internal_FPRepSem_i7nz4h2.FPStorage.field_0));
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE6encodeENS_4SignENS4_14BiasedExponentENS4_11SignificandE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::encode(__llvm_libc_20_1_2_::Sign, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::BiasedExponent, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand)")]
	public unsafe static short Invoke([MangledName("sign.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte Sign, [MangledName("exp.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::BiasedExponent")] int Exp, [MangledName("sig.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand")] short Sig)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h = default(Fputil_internal_FPRepSem_i7nz4h);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h2 = default(Fputil_internal_FPRepSem_i7nz4h);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h3 = default(Fputil_internal_FPRepSem_i7nz4h);
		anon_izyfb.Val = Sign;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0 = Exp;
		fputil_internal_FPRepSem_i7nz4h.FPStorage.field_0 = Sig;
		if (Sign_is_neg.Invoke(&anon_izyfb))
		{
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, 4L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_i7nz4h2, &fputil_internal_FPRepSem_i7nz4h, 2L, isVolatile: false);
			return unchecked((short)(0x8000 | (ushort)Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0, fputil_internal_FPRepSem_i7nz4h2.FPStorage.field_0)));
		}
		Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, 4L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_i7nz4h3, &fputil_internal_FPRepSem_i7nz4h, 2L, isVolatile: false);
		return Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0, fputil_internal_FPRepSem_i7nz4h3.FPStorage.field_0);
	}
}
