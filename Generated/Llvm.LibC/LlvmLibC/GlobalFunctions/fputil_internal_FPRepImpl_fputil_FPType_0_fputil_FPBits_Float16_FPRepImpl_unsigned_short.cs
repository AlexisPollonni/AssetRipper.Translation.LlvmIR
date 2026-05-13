using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEEC2Et")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::FPRepImpl(unsigned short)")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_FPRepImpl_unsigned_short
{
	public unsafe static void Invoke(fputil_internal_FPRepImpl_7z3gh9* @this, short x)
	{
		fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_FPRepSem_unsigned_short.Invoke(unchecked((fputil_internal_FPRepSem_i7nz4h*)@this), x);
	}
}
