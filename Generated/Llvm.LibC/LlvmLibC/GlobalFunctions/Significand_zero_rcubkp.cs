using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Significand_zero_rcubkp
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE1EE11Significand4zeroEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::Significand::zero()")]
	[CleanName("Significand_zero")]
	public unsafe static int Invoke()
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Significand_Constructor_vz3zem.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, 0);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0;
	}
}
