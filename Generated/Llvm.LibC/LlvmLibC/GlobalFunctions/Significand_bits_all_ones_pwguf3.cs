using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Significand_bits_all_ones_pwguf3
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE11Significand13bits_all_onesEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand::bits_all_ones()")]
	[CleanName("Significand_bits_all_ones")]
	public unsafe static short Invoke()
	{
		Fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h = default(Fputil_internal_FPRepSem_i7nz4h);
		Significand_Constructor_n44wpn.Invoke(&fputil_internal_FPRepSem_i7nz4h, 1023);
		return fputil_internal_FPRepSem_i7nz4h.FPStorage.field_0;
	}
}
