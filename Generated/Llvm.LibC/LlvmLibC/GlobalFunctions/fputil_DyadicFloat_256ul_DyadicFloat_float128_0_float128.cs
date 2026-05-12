using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm256EEC2IgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES6_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>::DyadicFloat<__float128, 0>(__float128)")]
internal static partial class fputil_DyadicFloat_256ul_DyadicFloat_float128_0_float128
{
	public unsafe static void Invoke(fputil_DyadicFloat_jhcpjj* @this, double x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_x9dsed bigInt_x9dsed = default(BigInt_x9dsed);
		Int128 @int = default(Int128);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, Sign_POS.Pointer, 1L, isVolatile: false);
		@this->exponent = 0;
		BigInt_256ul_false_unsigned_long_BigInt_int_void_int.Invoke(&@this->mantissa, 0);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		*unchecked((Int128*)(&fputil_FPBits_ubgsi3)) = -6148914691236517206L;
		fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, x);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi3);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		@this->exponent = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_explicit_exponent_const.Invoke(&fputil_FPBits_ubgsi3) - 112;
		llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed);
		unchecked
		{
			Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3));
			Int128* num = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 int2 = @int;
			BigInt_256ul_false_unsigned_long_BigInt_unsigned_int128_void_unsigned_int128.Invoke(&bigInt_x9dsed, *(long*)(&int2), ((long*)(&int2))[1]);
			llvm_memcpy_p0_p0_i64.Invoke(&@this->mantissa, &bigInt_x9dsed, 32L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed);
			fputil_DyadicFloat_256ul_normalize.Invoke(@this);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		}
	}
}
