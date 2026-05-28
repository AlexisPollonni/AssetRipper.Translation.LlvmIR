using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exponent_zero_yk2rst
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE8Exponent4zeroEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Exponent::zero()")]
	[CleanName("Exponent_zero")]
	public unsafe static int Invoke()
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Exponent_Constructor_uexxwm.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, 0);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0;
	}
}
