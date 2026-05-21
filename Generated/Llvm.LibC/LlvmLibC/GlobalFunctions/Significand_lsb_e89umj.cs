using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Significand_lsb_e89umj
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE11Significand3lsbEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand::lsb()")]
	[CleanName("Significand_lsb")]
	public unsafe static short Invoke()
	{
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h);
		Significand_Constructor_n44wpn.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h, 1);
		return llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h.FPStorage.field_0;
	}
}
