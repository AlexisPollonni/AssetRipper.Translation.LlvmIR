using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_BitwiseOr_vrvz5t
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalorENS1_9FPStorageILNS0_6FPTypeE2EE11SignificandES5_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator|(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand)")]
	[CleanName("internal_BitwiseOr")]
	public unsafe static long Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand")] long a, [MangledName("b.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand")] long b)
	{
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg3 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg4 = default(fputil_internal_FPRepSem_fq8nhg);
		fputil_internal_FPRepSem_fq8nhg3.FPStorage.val = a;
		fputil_internal_FPRepSem_fq8nhg4.FPStorage.val = b;
		Significand_Constructor_zv26wp.Invoke(&fputil_internal_FPRepSem_fq8nhg2, TypedInt_unsigned_long_to_storage_type.Invoke(&fputil_internal_FPRepSem_fq8nhg3) | TypedInt_unsigned_long_to_storage_type.Invoke(&fputil_internal_FPRepSem_fq8nhg4));
		return fputil_internal_FPRepSem_fq8nhg2.FPStorage.val;
	}
}
