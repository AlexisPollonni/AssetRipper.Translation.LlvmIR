using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEECI2NS1_9FPStorageILS3_0EEEEt")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::FPRepSem(unsigned short)")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_FPRepSem_unsigned_short
{
	public unsafe static void Invoke(fputil_internal_FPRepSem_i7nz4h* @this, short parameter_1)
	{
		fputil_internal_FPStorage_fputil_FPType_0_FPStorage_unsigned_short.Invoke(@this, parameter_1);
	}
}
