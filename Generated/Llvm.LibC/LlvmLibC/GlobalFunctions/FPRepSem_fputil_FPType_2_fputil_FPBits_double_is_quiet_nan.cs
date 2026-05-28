using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE2ENS0_6FPBitsIdEEE12is_quiet_nanEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::is_quiet_nan() const")]
	public unsafe static bool Invoke([MangledName("this")] Fputil_internal_FPRepSem_fq8nhg* This)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg = default(Fputil_internal_FPRepSem_fq8nhg);
		long num = FPStorage_fputil_FPType_2_exp_sig_bits.Invoke(This);
		int field_ = Exponent_inf_njkgzq.Invoke();
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = field_;
		BiasedExponent_Constructor_mpcgxb.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
		long val = Significand_msb_b4svue.Invoke();
		fputil_internal_FPRepSem_fq8nhg.FPStorage.Val = val;
		return unchecked((ulong)num >= (ulong)FPStorage_fputil_FPType_2_encode.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0, fputil_internal_FPRepSem_fq8nhg.FPStorage.Val));
	}
}
