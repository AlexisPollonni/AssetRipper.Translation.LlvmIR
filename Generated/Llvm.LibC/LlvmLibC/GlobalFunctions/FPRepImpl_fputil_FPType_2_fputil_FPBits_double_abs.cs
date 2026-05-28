using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE3absEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::abs() const")]
	public unsafe static long Invoke([MangledName("this")] Fputil_internal_FPRepImpl_ucubaq* This)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm, unchecked((Fputil_internal_FPStorage_v3nexn*)This)->Val & 0x7FFFFFFFFFFFFFFFL);
		return fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val;
	}
}
