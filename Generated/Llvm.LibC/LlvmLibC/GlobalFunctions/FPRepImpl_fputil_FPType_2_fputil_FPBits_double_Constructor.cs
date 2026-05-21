using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_2_fputil_FPBits_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEEC2Em")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::FPRepImpl(unsigned long)")]
	public unsafe static void Invoke(fputil_internal_FPRepImpl_ucubaq* @this, [NativeType("unsigned long")] long x)
	{
		FPRepSem_fputil_FPType_2_fputil_FPBits_double_Constructor.Invoke(unchecked((fputil_internal_FPRepSem_fq8nhg*)@this), x);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::FPRepImpl()")]
	public unsafe static void Invoke(fputil_internal_FPRepImpl_ucubaq* @this)
	{
		FPRepSem_fputil_FPType_2_fputil_FPBits_double_Constructor.Invoke(unchecked((fputil_internal_FPRepSem_fq8nhg*)@this));
	}
}
