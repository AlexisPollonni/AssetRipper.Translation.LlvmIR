using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE11set_uintvalEm")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::set_uintval(unsigned long)")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_uintval_unsigned_long
{
	public unsafe static void Invoke(fputil_internal_FPRepImpl_ucubaq* @this, long value)
	{
		unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val = value & -1L;
	}
}
