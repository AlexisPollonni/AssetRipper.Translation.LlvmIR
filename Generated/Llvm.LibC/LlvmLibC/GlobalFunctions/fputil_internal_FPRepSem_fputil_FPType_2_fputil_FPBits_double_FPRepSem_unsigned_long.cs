using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE2ENS0_6FPBitsIdEEECI2NS1_9FPStorageILS3_2EEEEm")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::FPRepSem(unsigned long)")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_FPRepSem_unsigned_long
{
	public unsafe static void Invoke(void* @this, long parameter_1)
	{
		fputil_internal_FPStorage_fputil_FPType_2_FPStorage_unsigned_long.Invoke(@this, parameter_1);
	}
}
