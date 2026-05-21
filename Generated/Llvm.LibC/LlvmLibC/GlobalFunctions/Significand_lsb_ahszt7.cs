using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Significand_lsb_ahszt7
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE11Significand3lsbEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand::lsb()")]
	[CleanName("Significand_lsb")]
	public unsafe static long Invoke()
	{
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = default(fputil_internal_FPRepSem_fq8nhg);
		Significand_Constructor_zv26wp.Invoke(&fputil_internal_FPRepSem_fq8nhg2, 1L);
		return fputil_internal_FPRepSem_fq8nhg2.FPStorage.val;
	}
}
