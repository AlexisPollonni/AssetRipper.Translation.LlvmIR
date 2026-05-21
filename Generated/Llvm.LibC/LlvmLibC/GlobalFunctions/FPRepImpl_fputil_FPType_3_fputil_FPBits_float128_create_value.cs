using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_create_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE3ENS0_6FPBitsIgEEE12create_valueENS_4SignEoo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>::create_value(__llvm_libc_20_1_2_::Sign, unsigned __int128, unsigned __int128)")]
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
			BiasedExponent_Constructor_ugybtz.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, (int)int4);
			Int128 int6 = int5;
			Significand_Constructor_rhfmvq.Invoke(&fputil_internal_FPRepSem_f94eua2, *(long*)(&int6), ((long*)(&int6))[1]);
			Struct_fiz2nb struct_fiz2nb = FPStorage_fputil_FPType_3_encode.Invoke(anon_izyfb9.val, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0, *(long*)(&fputil_internal_FPRepSem_f94eua2), ((long*)(&fputil_internal_FPRepSem_f94eua2))[1]);
			Int128* num = &int3;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&int3) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 int7 = int3;
			FPBits_float128_FPBits_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int7), ((long*)(&int7))[1]);
			return *(Struct_fiz2nb*)(&fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0);
		}
	}
}
