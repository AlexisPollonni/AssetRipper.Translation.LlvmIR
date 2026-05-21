using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEEC2Et")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::FPRepImpl(unsigned short)")]
	public unsafe static void Invoke(fputil_internal_FPRepImpl_7z3gh9* @this, [NativeType("unsigned short")] short x)
	{
		FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_Constructor.Invoke(unchecked((fputil_internal_FPRepSem_i7nz4h*)@this), x);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::FPRepImpl()")]
	public unsafe static void Invoke(fputil_internal_FPRepImpl_7z3gh9* @this)
	{
		FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_Constructor.Invoke(unchecked((fputil_internal_FPRepSem_i7nz4h*)@this));
	}
}
