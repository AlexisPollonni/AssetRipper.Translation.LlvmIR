using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::FPRepSem()")]
	public unsafe static void Invoke([MangledName("this")] Fputil_internal_FPRepSem_i7nz4h* This)
	{
		FPStorage_fputil_FPType_0_Constructor.Invoke(This);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEECI2NS1_9FPStorageILS3_0EEEEt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::FPRepSem(unsigned short)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_internal_FPRepSem_i7nz4h* This, [NativeType("unsigned short")] short parameter_1)
	{
		FPStorage_fputil_FPType_0_Constructor.Invoke(This, parameter_1);
	}
}
