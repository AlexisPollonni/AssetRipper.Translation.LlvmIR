using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_16ul_DyadicFloat_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm16EEC2IDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<16ul>::DyadicFloat<_Float16, 0>(_Float16)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_DyadicFloat_jvghxm* This, [MangledName("x")][NativeType("_Float16")] Half X)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		BigInt_ys7s55 bigInt_ys7s = default(BigInt_ys7s55);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, Sign_POS.Pointer, 1L, isVolatile: false);
		This->Exponent = 0;
		BigInt_16ul_false_unsigned_short_BigInt_int_void.Invoke(&This->Mantissa, 0);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		*unchecked((short*)(&fputil_FPBits_2fahva)) = -21846;
		FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		anon_izyfb.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		This->Exponent = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_exponent.Invoke(unchecked((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva))) - 10;
		Llvm_lifetime_start_p0.Invoke(2L, &bigInt_ys7s);
		BigInt_16ul_false_unsigned_short_BigInt_unsigned_short_void.Invoke(&bigInt_ys7s, FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa.Invoke(unchecked((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva))));
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Mantissa, &bigInt_ys7s, 2L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(2L, &bigInt_ys7s);
		DyadicFloat_16ul_normalize.Invoke(This);
		Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
	}
}
