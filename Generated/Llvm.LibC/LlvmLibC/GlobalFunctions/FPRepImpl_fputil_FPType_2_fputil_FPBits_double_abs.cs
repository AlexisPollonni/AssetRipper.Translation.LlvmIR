using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE3absEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::abs() const")]
	public unsafe static long Invoke(fputil_internal_FPRepImpl_ucubaq* @this)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val & 0x7FFFFFFFFFFFFFFFL);
		return fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val;
	}
}
