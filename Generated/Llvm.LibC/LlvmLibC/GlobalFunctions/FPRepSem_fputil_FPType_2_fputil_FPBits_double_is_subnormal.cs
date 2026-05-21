using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE2ENS0_6FPBitsIdEEE12is_subnormalEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::is_subnormal() const")]
	public unsafe static bool Invoke(fputil_internal_FPRepSem_fq8nhg* @this)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		long num = FPStorage_fputil_FPType_2_exp_bits.Invoke(@this);
		int field_ = Exponent_subnormal_ea7q23.Invoke();
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0 = field_;
		BiasedExponent_Constructor_mpcgxb.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0);
		return num == FPStorage_fputil_FPType_2_encode.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
	}
}
