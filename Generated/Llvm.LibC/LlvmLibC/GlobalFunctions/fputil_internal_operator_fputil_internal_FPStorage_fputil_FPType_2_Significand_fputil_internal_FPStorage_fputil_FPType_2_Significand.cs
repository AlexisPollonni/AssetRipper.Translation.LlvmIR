using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalorENS1_9FPStorageILNS0_6FPTypeE2EE11SignificandES5_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator|(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand)")]
internal static partial class fputil_internal_operator_fputil_internal_FPStorage_fputil_FPType_2_Significand_fputil_internal_FPStorage_fputil_FPType_2_Significand
{
	public unsafe static long Invoke([MangledName("a.coerce")] long a, [MangledName("b.coerce")] long b)
	{
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg3 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg4 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPRepSem_fq8nhg3.FPStorage.val = a;
		fputil_internal_FPRepSem_fq8nhg4.FPStorage.val = b;
		fputil_internal_FPStorage_fputil_FPType_2_Significand_Significand_unsigned_long.Invoke(&fputil_internal_FPRepSem_fq8nhg2, fputil_internal_FPStorage_fputil_FPType_2_TypedInt_unsigned_long_to_storage_type_const.Invoke(&fputil_internal_FPRepSem_fq8nhg3) | fputil_internal_FPStorage_fputil_FPType_2_TypedInt_unsigned_long_to_storage_type_const.Invoke(&fputil_internal_FPRepSem_fq8nhg4));
		return fputil_internal_FPRepSem_fq8nhg2.FPStorage.val;
	}
}
