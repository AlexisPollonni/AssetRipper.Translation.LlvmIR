using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_64ul_DyadicFloat_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EEC2IdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::DyadicFloat<double, 0>(double)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_syracv* This, [MangledName("x")][NativeType("double")] double X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
		This->Exponent = 0;
		BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&This->Mantissa, 0);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		*unchecked((long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) = -6148914691236517206L;
		FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, X);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		This->Exponent = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_explicit_exponent.Invoke(unchecked((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm))) - 52;
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs);
		BigInt_64ul_false_unsigned_long_BigInt_unsigned_long_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs, FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke(unchecked((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm))));
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Mantissa, &llvm_libc_20_1_2_BigInt_555ggs, 8L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs);
		DyadicFloat_64ul_normalize.Invoke(This);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
	}
}
