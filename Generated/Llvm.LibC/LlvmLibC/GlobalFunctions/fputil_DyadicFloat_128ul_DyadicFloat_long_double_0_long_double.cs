using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EEC2IeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES6_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::DyadicFloat<long double, 0>(long double)")]
internal static partial class fputil_DyadicFloat_128ul_DyadicFloat_long_double_0_long_double
{
	public unsafe static void Invoke(fputil_DyadicFloat_kt2kd4* @this, double x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		Int128 @int = default(Int128);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, Sign_POS.Pointer, 1L, isVolatile: false);
		@this->exponent = 0;
		unchecked
		{
			BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke((anon_izyfb7*)(&@this->mantissa), 0);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
			llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			@this->exponent = checked(fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_exponent_const.Invoke(&fputil_FPBits_ubgsi3) - 63);
			llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
			Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
			Int128* num = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 int2 = @int;
			BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void_unsigned_int128.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), *(long*)(&int2), ((long*)(&int2))[1]);
			llvm_memcpy_p0_p0_i64.Invoke(&@this->mantissa, &bigInt_qdkjbh, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
			fputil_DyadicFloat_128ul_normalize.Invoke(@this);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		}
	}
}
