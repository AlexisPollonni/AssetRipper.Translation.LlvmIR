using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalrsENS1_9FPStorageILNS0_6FPTypeE2EE11SignificandEi")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator>>(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand, int)")]
internal static partial class fputil_internal_operator_fputil_internal_FPStorage_fputil_FPType_2_Significand_int
{
	public unsafe static long Invoke([MangledName("a.coerce")] long a, int shift)
	{
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg3 = new fputil_internal_FPRepSem_fq8nhg
		{
			FPStorage = 
			{
				val = a
			}
		};
		fputil_internal_FPStorage_fputil_FPType_2_Significand_Significand_unsigned_long.Invoke(&fputil_internal_FPRepSem_fq8nhg2, fputil_internal_FPStorage_fputil_FPType_2_TypedInt_unsigned_long_to_storage_type_const.Invoke(&fputil_internal_FPRepSem_fq8nhg3) >>> unchecked((int)(uint)shift));
		return fputil_internal_FPRepSem_fq8nhg2.FPStorage.val;
	}
}
