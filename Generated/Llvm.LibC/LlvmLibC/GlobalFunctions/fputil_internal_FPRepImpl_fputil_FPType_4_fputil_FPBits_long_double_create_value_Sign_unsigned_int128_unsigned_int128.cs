using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE4ENS0_6FPBitsIeEEE12create_valueENS_4SignEoo")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::create_value(__llvm_libc_20_1_2_::Sign, unsigned __int128, unsigned __int128)")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_create_value_Sign_unsigned_int128_unsigned_int128
{
	public unsafe static Struct_fiz2nb Invoke([MangledName("sign.coerce")] sbyte sign, [MangledName("biased_exp.coerce0")] long biased_exp, [MangledName("biased_exp.coerce1")] long mantissa, [MangledName("mantissa.coerce0")] long mantissa_coerce0, [MangledName("mantissa.coerce1")] long mantissa_coerce1)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(fputil_internal_FPRepSem_f94eua);
		Int128 int3 = default(Int128);
		anon_izyfb8.val = sign;
		unchecked
		{
			*(long*)(&@int) = biased_exp;
			((long*)(&@int))[1] = mantissa;
			Int128 int4 = @int;
			*(long*)(&int2) = mantissa_coerce0;
			((long*)(&int2))[1] = mantissa_coerce1;
			Int128 int5 = int2;
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
			fputil_internal_FPStorage_fputil_FPType_4_BiasedExponent_BiasedExponent_unsigned_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, (int)int4);
			Int128 int6 = int5;
			fputil_internal_FPStorage_fputil_FPType_4_Significand_Significand_unsigned_int128.Invoke(&fputil_internal_FPRepSem_f94eua2, *(long*)(&int6), ((long*)(&int6))[1]);
			Struct_fiz2nb struct_fiz2nb = fputil_internal_FPStorage_fputil_FPType_4_encode_Sign_fputil_internal_FPStorage_fputil_FPType_4_BiasedExponent_fputil_internal_FPStorage_fputil_FPType_4_Significand.Invoke(anon_izyfb9.val, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0, *(long*)(&fputil_internal_FPRepSem_f94eua2), ((long*)(&fputil_internal_FPRepSem_f94eua2))[1]);
			Int128* num = &int3;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&int3) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 int7 = int3;
			fputil_FPBits_long_double_FPBits_unsigned_int128_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int7), ((long*)(&int7))[1]);
			return *(Struct_fiz2nb*)(&fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0);
		}
	}
}
