using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE11Significand3msbEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand::msb()")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_0_Significand_msb
{
	public unsafe static short Invoke()
	{
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h2 = default(fputil_internal_FPRepSem_i7nz4h);
		fputil_internal_FPStorage_fputil_FPType_0_Significand_Significand_unsigned_short.Invoke(&fputil_internal_FPRepSem_i7nz4h2, 512);
		return fputil_internal_FPRepSem_i7nz4h2.FPStorage.field_0;
	}
}
