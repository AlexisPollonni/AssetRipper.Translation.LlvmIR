using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE2ENS0_6FPBitsIdEEE9quiet_nanENS_4SignEm")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::quiet_nan(__llvm_libc_20_1_2_::Sign, unsigned long)")]
	public unsafe static long Invoke([MangledName("sign.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte sign, [NativeType("unsigned long")] long v)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg3 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg4 = default(fputil_internal_FPRepSem_fq8nhg);
		anon_izyfb8.val = sign;
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
		int field_ = Exponent_inf_njkgzq.Invoke();
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0 = field_;
		BiasedExponent_Constructor_mpcgxb.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0);
		long val = Significand_msb_b4svue.Invoke();
		fputil_internal_FPRepSem_fq8nhg3.FPStorage.val = val;
		Significand_Constructor_zv26wp.Invoke(&fputil_internal_FPRepSem_fq8nhg4, v);
		long val2 = internal_BitwiseOr_vrvz5t.Invoke(fputil_internal_FPRepSem_fq8nhg3.FPStorage.val, fputil_internal_FPRepSem_fq8nhg4.FPStorage.val);
		fputil_internal_FPRepSem_fq8nhg2.FPStorage.val = val2;
		FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, FPStorage_fputil_FPType_2_encode.Invoke(anon_izyfb9.val, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0, fputil_internal_FPRepSem_fq8nhg2.FPStorage.val));
		return fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val;
	}
}
