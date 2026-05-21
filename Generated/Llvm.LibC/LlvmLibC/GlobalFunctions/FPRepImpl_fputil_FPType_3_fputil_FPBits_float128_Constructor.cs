using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE3ENS0_6FPBitsIgEEEC2Eo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>::FPRepImpl(unsigned __int128)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("x.coerce0")] long X, [MangledName("x.coerce1")] long X_coerce1)
	{
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = X;
			((long*)(&@int))[1] = X_coerce1;
			Int128 int2 = @int;
			FPRepSem_fputil_FPType_3_fputil_FPBits_float128_Constructor.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)This, *(long*)(&int2), ((long*)(&int2))[1]);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE3ENS0_6FPBitsIgEEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>::FPRepImpl()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		FPRepSem_fputil_FPType_3_fputil_FPBits_float128_Constructor.Invoke(unchecked((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)This));
	}
}
