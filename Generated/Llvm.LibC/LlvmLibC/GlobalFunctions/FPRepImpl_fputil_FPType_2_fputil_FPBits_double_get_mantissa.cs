using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE12get_mantissaEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::get_mantissa() const")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq* This)
	{
		return unchecked((Llvm_libc_20_1_2_fputil_internal_FPStorage_v3nexn*)This)->Val & 0xFFFFFFFFFFFFFL;
	}
}
