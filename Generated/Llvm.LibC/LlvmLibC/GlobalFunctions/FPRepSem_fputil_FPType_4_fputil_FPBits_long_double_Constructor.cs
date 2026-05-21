using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::FPRepSem()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		FPStorage_fputil_FPType_4_Constructor.Invoke(This);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEECI2NS1_9FPStorageILS3_4EEEEo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::FPRepSem(unsigned __int128)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName(".coerce0")] long Coerce0, [MangledName(".coerce1")] long Coerce1)
	{
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = Coerce0;
			((long*)(&@int))[1] = Coerce1;
			Int128 int2 = @int;
			FPStorage_fputil_FPType_4_Constructor.Invoke(This, *(long*)(&int2), ((long*)(&int2))[1]);
		}
	}
}
