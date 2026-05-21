using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_Equals_wuhucm
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internaleqENS1_9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEEES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator==(__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>, __llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>)")]
	[CleanName("internal_Equals")]
	public unsafe static bool Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>")] int a, [MangledName("b.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>")] int b)
	{
		fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm2 = default(fputil_internal_FPRepImpl_vhj4tm);
		fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm3 = default(fputil_internal_FPRepImpl_vhj4tm);
		fputil_internal_FPRepImpl_vhj4tm2.FPRepSem.field_0.field_0 = a;
		fputil_internal_FPRepImpl_vhj4tm3.FPRepSem.field_0.field_0 = b;
		return FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke(&fputil_internal_FPRepImpl_vhj4tm2) == FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke(&fputil_internal_FPRepImpl_vhj4tm3);
	}
}
