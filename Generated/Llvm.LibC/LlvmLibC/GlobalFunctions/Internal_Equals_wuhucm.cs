using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_Equals_wuhucm
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internaleqENS1_9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEEES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator==(__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>, __llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>)")]
	[CleanName("Internal_Equals")]
	public unsafe static bool Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>")] int A, [MangledName("b.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>")] int B)
	{
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm);
		llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm.FPRepSem.field_0.field_0 = A;
		llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm2.FPRepSem.field_0.field_0 = B;
		return FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm) == FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm2);
	}
}
