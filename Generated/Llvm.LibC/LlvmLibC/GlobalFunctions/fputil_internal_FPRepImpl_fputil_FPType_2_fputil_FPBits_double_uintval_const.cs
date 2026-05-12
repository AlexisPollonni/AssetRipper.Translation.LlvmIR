using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE7uintvalEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::uintval() const")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const
{
	public unsafe static long Invoke(fputil_internal_FPRepImpl_ucubaq* @this)
	{
		return unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val & -1L;
	}
}
