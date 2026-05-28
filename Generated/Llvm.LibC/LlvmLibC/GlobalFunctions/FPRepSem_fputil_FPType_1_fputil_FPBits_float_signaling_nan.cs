using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_1_fputil_FPBits_float_signaling_nan
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE1ENS0_6FPBitsIfEEE13signaling_nanENS_4SignEj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::signaling_nan(__llvm_libc_20_1_2_::Sign, unsigned int)")]
	public unsafe static int Invoke([MangledName("sign.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte Sign, [MangledName("v")][NativeType("unsigned int")] int V)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		anon_izyfb.Val = Sign;
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
		int field_ = Exponent_inf_jjc7xf.Invoke();
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = field_;
		BiasedExponent_Constructor_f8cgks.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
		if (V != 0)
		{
			Significand_Constructor_vz3zem.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3, V);
		}
		else
		{
			int field_2 = Significand_msb_n94xcf.Invoke();
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4.field_0.field_0 = field_2;
			int field_3 = Internal_RightShift_xkdr4i.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4.field_0.field_0, 1);
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0 = field_3;
		}
		FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs, FPStorage_fputil_FPType_1_encode_vjifbe.Invoke(anon_izyfb2.Val, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0));
		return fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0;
	}
}
