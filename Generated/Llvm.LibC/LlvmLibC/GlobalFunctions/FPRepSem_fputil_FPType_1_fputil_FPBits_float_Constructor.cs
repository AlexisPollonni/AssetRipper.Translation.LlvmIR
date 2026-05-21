using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_1_fputil_FPBits_float_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE1ENS0_6FPBitsIfEEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::FPRepSem()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		FPStorage_fputil_FPType_1_Constructor.Invoke(This);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE1ENS0_6FPBitsIfEEECI2NS1_9FPStorageILS3_1EEEEj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::FPRepSem(unsigned int)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [NativeType("unsigned int")] int parameter_1)
	{
		FPStorage_fputil_FPType_1_Constructor.Invoke(This, parameter_1);
	}
}
