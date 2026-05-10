using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE11Significand13bits_all_onesEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand::bits_all_ones()")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_0_Significand_bits_all_ones
{
	public unsafe static short Invoke()
	{
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h2 = default(fputil_internal_FPRepSem_i7nz4h);
		fputil_internal_FPStorage_fputil_FPType_0_Significand_Significand_unsigned_short.Invoke(&fputil_internal_FPRepSem_i7nz4h2, 1023);
		return fputil_internal_FPRepSem_i7nz4h2.FPStorage.field_0;
	}
}
