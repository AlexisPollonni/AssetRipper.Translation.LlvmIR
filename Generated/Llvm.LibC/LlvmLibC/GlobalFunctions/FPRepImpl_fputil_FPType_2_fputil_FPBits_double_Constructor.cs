using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_2_fputil_FPBits_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEEC2Em")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::FPRepImpl(unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_internal_FPRepImpl_ucubaq* This, [MangledName("x")][NativeType("unsigned long")] long X)
	{
		FPRepSem_fputil_FPType_2_fputil_FPBits_double_Constructor.Invoke(unchecked((Fputil_internal_FPRepSem_fq8nhg*)This), X);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::FPRepImpl()")]
	public unsafe static void Invoke([MangledName("this")] Fputil_internal_FPRepImpl_ucubaq* This)
	{
		FPRepSem_fputil_FPType_2_fputil_FPBits_double_Constructor.Invoke(unchecked((Fputil_internal_FPRepSem_fq8nhg*)This));
	}
}
