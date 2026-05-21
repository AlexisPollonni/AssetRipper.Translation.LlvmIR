using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE4ENS0_6FPBitsIeEEEC2Eo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::FPRepImpl(unsigned __int128)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("x.coerce0")] long X, [MangledName("x.coerce1")] long X_coerce1)
	{
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = X;
			((long*)(&@int))[1] = X_coerce1;
			Int128 int2 = @int;
			FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_Constructor.Invoke(This, *(long*)(&int2), ((long*)(&int2))[1]);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE4ENS0_6FPBitsIeEEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::FPRepImpl()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_Constructor.Invoke(This);
	}
}
