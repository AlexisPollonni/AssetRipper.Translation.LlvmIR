using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE4ENS0_6FPBitsIeEEE19set_biased_exponentEo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::set_biased_exponent(unsigned __int128)")]
	public unsafe static void Invoke(void* @this, [MangledName("biased.coerce0")] long biased, [MangledName("biased.coerce1")] long biased_coerce1)
	{
		Int128 @int = default(Int128);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		unchecked
		{
			*(long*)(&@int) = biased;
			((long*)(&@int))[1] = biased_coerce1;
			BiasedExponent_Constructor_w8dba9.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, (int)@int);
			FPStorage_fputil_FPType_4_set_biased_exponent.Invoke(@this, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
		}
	}
}
