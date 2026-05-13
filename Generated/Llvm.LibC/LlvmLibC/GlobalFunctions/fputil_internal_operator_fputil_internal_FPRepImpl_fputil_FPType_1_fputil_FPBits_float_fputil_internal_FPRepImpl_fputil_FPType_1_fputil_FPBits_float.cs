using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internaleqENS1_9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEEES6_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator==(__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>, __llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>)")]
internal static partial class fputil_internal_operator_fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float
{
	public unsafe static bool Invoke([MangledName("a.coerce")] int a, [MangledName("b.coerce")] int b)
	{
		fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm2 = default(fputil_internal_FPRepImpl_vhj4tm);
		fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm3 = default(fputil_internal_FPRepImpl_vhj4tm);
		fputil_internal_FPRepImpl_vhj4tm2.FPRepSem.field_0.field_0 = a;
		fputil_internal_FPRepImpl_vhj4tm3.FPRepSem.field_0.field_0 = b;
		return fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_internal_FPRepImpl_vhj4tm2) == fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_internal_FPRepImpl_vhj4tm3);
	}
}
