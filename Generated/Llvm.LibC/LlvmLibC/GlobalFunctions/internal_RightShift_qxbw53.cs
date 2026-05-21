using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_RightShift_qxbw53
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalrsENS1_9FPStorageILNS0_6FPTypeE2EE11SignificandEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator>>(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand, int)")]
	[CleanName("internal_RightShift")]
	public unsafe static long Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand")] long a, [NativeType("int")] int shift)
	{
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg3 = new fputil_internal_FPRepSem_fq8nhg
		{
			FPStorage = 
			{
				val = a
			}
		};
		Significand_Constructor_zv26wp.Invoke(&fputil_internal_FPRepSem_fq8nhg2, TypedInt_unsigned_long_to_storage_type.Invoke(&fputil_internal_FPRepSem_fq8nhg3) >>> unchecked((int)(uint)shift));
		return fputil_internal_FPRepSem_fq8nhg2.FPStorage.val;
	}
}
