using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_DyadicFloat_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EEC2IgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::DyadicFloat<__float128, 0>(__float128)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_DyadicFloat_kt2kd4* This, [MangledName("x")][NativeType("__float128")] double X)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		Int128 @int = default(Int128);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, Sign_POS.Pointer, 1L, isVolatile: false);
		This->Exponent = 0;
		unchecked
		{
			BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&This->Mantissa), 0);
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi, X);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			anon_izyfb.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi);
			Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			This->Exponent = checked(FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_explicit_exponent.Invoke(&fputil_FPBits_ubgsi) - 112);
			Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
			Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi));
			Int128* num = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 int2 = @int;
			BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh), *(long*)(&int2), ((long*)(&int2))[1]);
			Llvm_memcpy_p0_p0_i64.Invoke(&This->Mantissa, &bigInt_qdkjbh, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
			DyadicFloat_128ul_normalize.Invoke(This);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		}
	}
}
