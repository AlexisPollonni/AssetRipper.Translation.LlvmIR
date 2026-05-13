using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE1ENS0_6FPBitsIfEEECI2NS1_9FPStorageILS3_1EEEEj")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::FPRepSem(unsigned int)")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_FPRepSem_unsigned_int
{
	public unsafe static void Invoke(void* @this, int parameter_1)
	{
		fputil_internal_FPStorage_fputil_FPType_1_FPStorage_unsigned_int.Invoke(@this, parameter_1);
	}
}
