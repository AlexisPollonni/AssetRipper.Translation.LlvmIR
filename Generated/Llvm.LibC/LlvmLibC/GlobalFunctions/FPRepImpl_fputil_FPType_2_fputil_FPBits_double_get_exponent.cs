using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE12get_exponentEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::get_exponent() const")]
	public unsafe static int Invoke([MangledName("this")] Fputil_internal_FPRepImpl_ucubaq* This)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2);
		int field_ = FPStorage_fputil_FPType_2_biased_exponent.Invoke(This);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = field_;
		int field_2 = BiasedExponent_Exponent_dg377q.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0 = field_2;
		int result = TypedInt_int_ToInt32_wp5j3s.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2);
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		return result;
	}
}
