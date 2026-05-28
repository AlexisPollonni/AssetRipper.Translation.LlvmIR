using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEE7uintvalEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::uintval() const")]
	public unsafe static int Invoke([MangledName("this")] Fputil_internal_FPRepImpl_vhj4tm* This)
	{
		return unchecked((Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 & -1;
	}
}
