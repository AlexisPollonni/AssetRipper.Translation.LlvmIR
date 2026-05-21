using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Significand_bits_all_ones_cz6sas
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE11Significand13bits_all_onesEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand::bits_all_ones()")]
	[CleanName("Significand_bits_all_ones")]
	public unsafe static long Invoke()
	{
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg);
		Significand_Constructor_zv26wp.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg, 4503599627370495L);
		return llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg.FPStorage.Val;
	}
}
