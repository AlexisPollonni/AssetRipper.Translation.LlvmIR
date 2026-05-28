using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_2_biased_exponent
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE15biased_exponentEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::biased_exponent() const")]
	public unsafe static int Invoke([MangledName("this")] void* This)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		BiasedExponent_Constructor_wmyua6.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, unchecked((int)(FPStorage_fputil_FPType_2_exp_bits.Invoke(This) >>> 52)));
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0;
	}
}
