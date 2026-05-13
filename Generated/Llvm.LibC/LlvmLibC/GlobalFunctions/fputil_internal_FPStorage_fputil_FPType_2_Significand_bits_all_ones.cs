using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE11Significand13bits_all_onesEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand::bits_all_ones()")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_2_Significand_bits_all_ones
{
	public unsafe static long Invoke()
	{
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPStorage_fputil_FPType_2_Significand_Significand_unsigned_long.Invoke(&fputil_internal_FPRepSem_fq8nhg2, 4503599627370495L);
		return fputil_internal_FPRepSem_fq8nhg2.FPStorage.val;
	}
}
