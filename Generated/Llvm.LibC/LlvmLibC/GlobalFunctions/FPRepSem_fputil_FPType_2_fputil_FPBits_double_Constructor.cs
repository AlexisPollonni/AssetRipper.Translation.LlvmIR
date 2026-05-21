using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_2_fputil_FPBits_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE2ENS0_6FPBitsIdEEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::FPRepSem()")]
	public unsafe static void Invoke(fputil_internal_FPRepSem_fq8nhg* @this)
	{
		FPStorage_fputil_FPType_2_Constructor.Invoke(@this);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE2ENS0_6FPBitsIdEEECI2NS1_9FPStorageILS3_2EEEEm")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::FPRepSem(unsigned long)")]
	public unsafe static void Invoke(fputil_internal_FPRepSem_fq8nhg* @this, [NativeType("unsigned long")] long parameter_1)
	{
		FPStorage_fputil_FPType_2_Constructor.Invoke(@this, parameter_1);
	}
}
