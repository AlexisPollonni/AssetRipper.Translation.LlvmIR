using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE11Significand3msbEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand::msb()")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_2_Significand_msb
{
	public unsafe static long Invoke()
	{
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPStorage_fputil_FPType_2_Significand_Significand_unsigned_long.Invoke(&fputil_internal_FPRepSem_fq8nhg2, 2251799813685248L);
		return fputil_internal_FPRepSem_fq8nhg2.FPStorage.val;
	}
}
