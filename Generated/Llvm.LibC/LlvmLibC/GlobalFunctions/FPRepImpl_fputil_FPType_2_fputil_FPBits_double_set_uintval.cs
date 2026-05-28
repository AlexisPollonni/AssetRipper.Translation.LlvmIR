using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_uintval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE11set_uintvalEm")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::set_uintval(unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_internal_FPRepImpl_ucubaq* This, [MangledName("value")][NativeType("unsigned long")] long Value)
	{
		unchecked((Fputil_internal_FPStorage_v3nexn*)This)->Val = Value & -1L;
	}
}
