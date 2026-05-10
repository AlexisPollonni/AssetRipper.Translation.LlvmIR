using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE6encodeENS_4SignENS4_14BiasedExponentENS4_11SignificandE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::encode(__llvm_libc_20_1_2_::Sign, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::BiasedExponent, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_3_encode_Sign_fputil_internal_FPStorage_fputil_FPType_3_BiasedExponent_fputil_internal_FPStorage_fputil_FPType_3_Significand
{
	public unsafe static Struct_fiz2nb Invoke([MangledName("sign.coerce")] sbyte sign, [MangledName("exp.coerce")] int exp, [MangledName("sig.coerce0")] long sig, [MangledName("sig.coerce1")] long sig_coerce1)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(fputil_internal_FPRepSem_f94eua);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua3 = default(fputil_internal_FPRepSem_f94eua);
		Int128 @int = default(Int128);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua4 = default(fputil_internal_FPRepSem_f94eua);
		Int128 int2 = default(Int128);
		anon_izyfb8.val = sign;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = exp;
		unchecked
		{
			*(long*)(&fputil_internal_FPRepSem_f94eua2) = sig;
			((long*)(&fputil_internal_FPRepSem_f94eua2))[1] = sig_coerce1;
			Int128 int3;
			if (Sign_is_neg_const.Invoke(&anon_izyfb8))
			{
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, 4L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_f94eua3, &fputil_internal_FPRepSem_f94eua2, 16L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = fputil_internal_FPStorage_fputil_FPType_3_encode_fputil_internal_FPStorage_fputil_FPType_3_BiasedExponent_fputil_internal_FPStorage_fputil_FPType_3_Significand.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0, *(long*)(&fputil_internal_FPRepSem_f94eua3), ((long*)(&fputil_internal_FPRepSem_f94eua3))[1]);
				Int128* num = &@int;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num = struct_fiz2nb2.field_0;
				byte* num2 = (byte*)(&@int) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb3.field_1;
				int3 = NumericHelper.BitwiseOr(y: @int, x: 0L);
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, 4L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_f94eua4, &fputil_internal_FPRepSem_f94eua2, 16L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPStorage_fputil_FPType_3_encode_fputil_internal_FPStorage_fputil_FPType_3_BiasedExponent_fputil_internal_FPStorage_fputil_FPType_3_Significand.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4.field_0.field_0, *(long*)(&fputil_internal_FPRepSem_f94eua4), ((long*)(&fputil_internal_FPRepSem_f94eua4))[1]);
				Int128* num3 = &int2;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				*(long*)num3 = struct_fiz2nb5.field_0;
				byte* num4 = (byte*)(&int2) + 8u;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				*(long*)num4 = struct_fiz2nb6.field_1;
				int3 = int2;
			}
			return *(Struct_fiz2nb*)(&int3);
		}
	}
}
