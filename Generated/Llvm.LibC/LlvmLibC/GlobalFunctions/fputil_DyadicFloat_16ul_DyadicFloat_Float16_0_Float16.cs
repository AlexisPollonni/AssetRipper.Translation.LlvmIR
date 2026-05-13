using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm16EEC2IDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES6_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<16ul>::DyadicFloat<_Float16, 0>(_Float16)")]
internal static partial class fputil_DyadicFloat_16ul_DyadicFloat_Float16_0_Float16
{
	public unsafe static void Invoke(fputil_DyadicFloat_jvghxm* @this, Half x)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_ys7s55 bigInt_ys7s = default(BigInt_ys7s55);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, Sign_POS.Pointer, 1L, isVolatile: false);
		@this->exponent = 0;
		BigInt_16ul_false_unsigned_short_BigInt_int_void_int.Invoke(&@this->mantissa, 0);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		*unchecked((short*)(&fputil_FPBits_2fahva2)) = -21846;
		fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_0_sign_const.Invoke(&fputil_FPBits_2fahva2);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		@this->exponent = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_exponent_const.Invoke(unchecked((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))) - 10;
		llvm_lifetime_start_p0.Invoke(2L, &bigInt_ys7s);
		BigInt_16ul_false_unsigned_short_BigInt_unsigned_short_void_unsigned_short.Invoke(&bigInt_ys7s, fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa_const.Invoke(unchecked((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2))));
		llvm_memcpy_p0_p0_i64.Invoke(&@this->mantissa, &bigInt_ys7s, 2L, isVolatile: false);
		llvm_lifetime_end_p0.Invoke(2L, &bigInt_ys7s);
		fputil_DyadicFloat_16ul_normalize.Invoke(@this);
		llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
	}
}
