using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEE19set_biased_exponentEj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::set_biased_exponent(unsigned int)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_internal_FPRepImpl_vhj4tm* This, [MangledName("biased")][NativeType("unsigned int")] int Biased)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		BiasedExponent_Constructor_j5uhfg.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, Biased);
		FPStorage_fputil_FPType_1_set_biased_exponent.Invoke(This, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0);
	}
}
