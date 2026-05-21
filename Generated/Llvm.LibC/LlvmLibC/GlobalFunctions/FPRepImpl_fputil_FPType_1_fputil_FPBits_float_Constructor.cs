using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_1_fputil_FPBits_float_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEEC2Ej")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::FPRepImpl(unsigned int)")]
	public unsafe static void Invoke(fputil_internal_FPRepImpl_vhj4tm* @this, [NativeType("unsigned int")] int x)
	{
		FPRepSem_fputil_FPType_1_fputil_FPBits_float_Constructor.Invoke(@this, x);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::FPRepImpl()")]
	public unsafe static void Invoke(fputil_internal_FPRepImpl_vhj4tm* @this)
	{
		FPRepSem_fputil_FPType_1_fputil_FPBits_float_Constructor.Invoke(@this);
	}
}
