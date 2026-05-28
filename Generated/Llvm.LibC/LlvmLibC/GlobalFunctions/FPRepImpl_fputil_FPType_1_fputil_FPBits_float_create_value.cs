using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEE12create_valueENS_4SignEjj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::create_value(__llvm_libc_20_1_2_::Sign, unsigned int, unsigned int)")]
	public unsafe static int Invoke([MangledName("sign.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte Sign, [MangledName("biased_exp")][NativeType("unsigned int")] int Biased_exp, [MangledName("mantissa")][NativeType("unsigned int")] int Mantissa)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		anon_izyfb.Val = Sign;
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
		BiasedExponent_Constructor_j5uhfg.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, Biased_exp);
		Significand_Constructor_vz3zem.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, Mantissa);
		FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs, FPStorage_fputil_FPType_1_encode_vjifbe.Invoke(anon_izyfb2.Val, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0));
		return fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0;
	}
}
