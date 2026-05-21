using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE2ENS0_6FPBitsIdEEE9quiet_nanENS_4SignEm")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::quiet_nan(__llvm_libc_20_1_2_::Sign, unsigned long)")]
	public unsafe static long Invoke([MangledName("sign.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte Sign, [MangledName("v")][NativeType("unsigned long")] long V)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg3 = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg);
		anon_izyfb.Val = Sign;
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
		int field_ = Exponent_inf_njkgzq.Invoke();
		llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = field_;
		BiasedExponent_Constructor_mpcgxb.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
		long val = Significand_msb_b4svue.Invoke();
		llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg2.FPStorage.Val = val;
		Significand_Constructor_zv26wp.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg3, V);
		long val2 = Internal_BitwiseOr_vrvz5t.Invoke(llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg2.FPStorage.Val, llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg3.FPStorage.Val);
		llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg.FPStorage.Val = val2;
		FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, FPStorage_fputil_FPType_2_encode.Invoke(anon_izyfb2.Val, llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0, llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg.FPStorage.Val));
		return llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val;
	}
}
