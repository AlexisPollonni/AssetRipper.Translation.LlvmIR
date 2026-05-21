using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE12create_valueENS_4SignEmm")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::create_value(__llvm_libc_20_1_2_::Sign, unsigned long, unsigned long)")]
	public unsafe static long Invoke([MangledName("sign.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte sign, [NativeType("unsigned long")] long biased_exp, [NativeType("unsigned long")] long mantissa)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = default(fputil_internal_FPRepSem_fq8nhg);
		anon_izyfb8.val = sign;
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
		BiasedExponent_Constructor_wmyua6.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, unchecked((int)biased_exp));
		Significand_Constructor_zv26wp.Invoke(&fputil_internal_FPRepSem_fq8nhg2, mantissa);
		FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, FPStorage_fputil_FPType_2_encode.Invoke(anon_izyfb9.val, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0, fputil_internal_FPRepSem_fq8nhg2.FPStorage.val));
		return fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val;
	}
}
