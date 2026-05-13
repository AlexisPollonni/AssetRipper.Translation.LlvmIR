using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internaleqENS1_9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEEES6_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator==(__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>, __llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>)")]
internal static partial class fputil_internal_operator_fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double
{
	public unsafe static bool Invoke([MangledName("a.coerce")] long a, [MangledName("b.coerce")] long b)
	{
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq2 = default(fputil_internal_FPRepImpl_ucubaq);
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq3 = default(fputil_internal_FPRepImpl_ucubaq);
		fputil_internal_FPRepImpl_ucubaq2.FPRepSem.FPStorage.val = a;
		fputil_internal_FPRepImpl_ucubaq3.FPRepSem.FPStorage.val = b;
		return fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_internal_FPRepImpl_ucubaq2) == fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_internal_FPRepImpl_ucubaq3);
	}
}
