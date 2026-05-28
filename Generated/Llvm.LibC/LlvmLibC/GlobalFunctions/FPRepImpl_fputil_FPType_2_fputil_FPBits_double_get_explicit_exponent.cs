using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_explicit_exponent
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE21get_explicit_exponentEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::get_explicit_exponent() const")]
	public unsafe static int Invoke([MangledName("this")] Fputil_internal_FPRepImpl_ucubaq* This)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent5 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		unchecked
		{
			*(int*)(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent) = -1431655766;
			Llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2);
			int field_ = FPStorage_fputil_FPType_2_biased_exponent.Invoke(This);
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = field_;
			int field_2 = BiasedExponent_Exponent_dg377q.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2);
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0 = field_2;
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2);
			if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)This))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3);
				int field_3 = Exponent_zero_xmxrwd.Invoke();
				fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0 = field_3;
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3, 4L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3);
			}
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, 4L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4);
			int field_4 = Exponent_subnormal_ea7q23.Invoke();
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4.field_0.field_0 = field_4;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4, 4L, isVolatile: false);
			bool num = Internal_Equals_ce2pur.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4);
			if (num)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent5);
				int field_5 = Exponent_min_auin9g.Invoke();
				fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent5.field_0.field_0 = field_5;
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent5, 4L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent5);
			}
			int result = TypedInt_int_ToInt32_wp5j3s.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
			return result;
		}
	}
}
