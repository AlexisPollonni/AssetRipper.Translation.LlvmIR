using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_significand
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE15set_significandEm")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::set_significand(unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq* This, [MangledName("sigVal")][NativeType("unsigned long")] long SigVal)
	{
		unchecked
		{
			((Llvm_libc_20_1_2_fputil_internal_FPStorage_v3nexn*)This)->Val = FPStorage_fputil_FPType_2_merge.Invoke(((Llvm_libc_20_1_2_fputil_internal_FPStorage_v3nexn*)This)->Val, SigVal, 4503599627370495L);
		}
	}
}
