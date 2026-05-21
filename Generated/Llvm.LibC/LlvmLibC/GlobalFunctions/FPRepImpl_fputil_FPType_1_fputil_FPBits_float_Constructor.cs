using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_1_fputil_FPBits_float_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEEC2Ej")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::FPRepImpl(unsigned int)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm* This, [MangledName("x")][NativeType("unsigned int")] int X)
	{
		FPRepSem_fputil_FPType_1_fputil_FPBits_float_Constructor.Invoke(This, X);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::FPRepImpl()")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm* This)
	{
		FPRepSem_fputil_FPType_1_fputil_FPBits_float_Constructor.Invoke(This);
	}
}
