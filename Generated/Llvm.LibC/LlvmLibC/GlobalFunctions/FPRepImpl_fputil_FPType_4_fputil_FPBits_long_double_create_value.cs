using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_create_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE4ENS0_6FPBitsIeEEE12create_valueENS_4SignEoo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::create_value(__llvm_libc_20_1_2_::Sign, unsigned __int128, unsigned __int128)")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("sign.coerce")] sbyte Sign, [MangledName("biased_exp.coerce0")] long Biased_exp, [MangledName("biased_exp.coerce1")] long Mantissa, [MangledName("mantissa.coerce0")] long Mantissa_coerce0, [MangledName("mantissa.coerce1")] long Mantissa_coerce1)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua);
		Int128 int3 = default(Int128);
		anon_izyfb.Val = Sign;
		unchecked
		{
			*(long*)(&@int) = Biased_exp;
			((long*)(&@int))[1] = Mantissa;
			Int128 int4 = @int;
			*(long*)(&int2) = Mantissa_coerce0;
			((long*)(&int2))[1] = Mantissa_coerce1;
			Int128 int5 = int2;
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
			BiasedExponent_Constructor_w8dba9.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, (int)int4);
			Int128 int6 = int5;
			Significand_Constructor_j3ersh.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua, *(long*)(&int6), ((long*)(&int6))[1]);
			Struct_fiz2nb struct_fiz2nb = FPStorage_fputil_FPType_4_encode.Invoke(anon_izyfb2.Val, llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0, *(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua))[1]);
			Int128* num = &int3;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&int3) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 int7 = int3;
			FPBits_long_double_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int7), ((long*)(&int7))[1]);
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi.Val.Data.FPStorage.field_0);
		}
	}
}
