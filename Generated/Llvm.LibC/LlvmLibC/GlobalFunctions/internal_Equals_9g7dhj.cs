using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_Equals_9g7dhj
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internaleqENS1_9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEEES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator==(__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>, __llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>)")]
	[CleanName("internal_Equals")]
	public unsafe static bool Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>")] short a, [MangledName("b.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>")] short b)
	{
		fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh10 = default(fputil_internal_FPRepImpl_7z3gh9);
		fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh11 = default(fputil_internal_FPRepImpl_7z3gh9);
		fputil_internal_FPRepImpl_7z3gh10.FPRepSem.FPStorage.field_0 = a;
		fputil_internal_FPRepImpl_7z3gh11.FPRepSem.FPStorage.field_0 = b;
		return unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke(&fputil_internal_FPRepImpl_7z3gh10) == (ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke(&fputil_internal_FPRepImpl_7z3gh11));
	}
}
