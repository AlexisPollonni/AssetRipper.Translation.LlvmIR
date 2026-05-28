using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_subnormal
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE12is_subnormalEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::is_subnormal() const")]
	public unsafe static bool Invoke([MangledName("this")] Fputil_internal_FPRepSem_i7nz4h* This)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		unchecked
		{
			ushort num = (ushort)FPStorage_fputil_FPType_0_exp_bits.Invoke(This);
			int field_ = Exponent_subnormal_xfvcpw.Invoke();
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = field_;
			BiasedExponent_Constructor_jrjdb5.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
			return num == (ushort)FPStorage_fputil_FPType_0_encode.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0);
		}
	}
}
