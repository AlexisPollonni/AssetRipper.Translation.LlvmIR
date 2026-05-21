using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_Equals_r4buia
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internaleqENS1_9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEEES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator==(__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>, __llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>)")]
	[CleanName("Internal_Equals")]
	public unsafe static bool Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>")] long A, [MangledName("b.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>")] long B)
	{
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq);
		llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq.FPRepSem.FPStorage.Val = A;
		llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq2.FPRepSem.FPStorage.Val = B;
		return FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq) == FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq2);
	}
}
