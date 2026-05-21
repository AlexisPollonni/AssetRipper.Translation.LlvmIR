using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE12create_valueENS_4SignEtt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::create_value(__llvm_libc_20_1_2_::Sign, unsigned short, unsigned short)")]
	public unsafe static short Invoke([MangledName("sign.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte Sign, [MangledName("biased_exp")][NativeType("unsigned short")] short Biased_exp, [MangledName("mantissa")][NativeType("unsigned short")] short Mantissa)
	{
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h);
		anon_izyfb.Val = Sign;
		short parameter_ = Mantissa;
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
		BiasedExponent_Constructor_wry333.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, unchecked((ushort)Biased_exp));
		Significand_Constructor_n44wpn.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h, parameter_);
		FPBits_Float16_FPBits_unsigned_short.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva, FPStorage_fputil_FPType_0_encode.Invoke(anon_izyfb2.Val, llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0, llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h.FPStorage.field_0));
		return llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0;
	}
}
