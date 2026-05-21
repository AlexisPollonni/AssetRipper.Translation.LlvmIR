using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_DyadicFloat_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EEC2IdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::DyadicFloat<double, 0>(double)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* This, [MangledName("x")][NativeType("double")] double X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
		This->Exponent = 0;
		unchecked
		{
			BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&This->Mantissa), 0);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		}
		This->Exponent = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_explicit_exponent.Invoke(unchecked((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm))) - 52;
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
		unchecked
		{
			BigInt_128ul_false_unsigned_long_BigInt_unsigned_long_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)));
			Llvm_memcpy_p0_p0_i64.Invoke(&This->Mantissa, &llvm_libc_20_1_2_BigInt_qdkjbh, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
			DyadicFloat_128ul_normalize.Invoke(This);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		}
	}
}
