using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_BitwiseOr_vrvz5t
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalorENS1_9FPStorageILNS0_6FPTypeE2EE11SignificandES5_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator|(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand)")]
	[CleanName("Internal_BitwiseOr")]
	public unsafe static long Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand")] long A, [MangledName("b.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand")] long B)
	{
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg3 = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg);
		llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg2.FPStorage.Val = A;
		llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg3.FPStorage.Val = B;
		Significand_Constructor_zv26wp.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg, TypedInt_unsigned_long_to_storage_type.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg2) | TypedInt_unsigned_long_to_storage_type.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg3));
		return llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg.FPStorage.Val;
	}
}
