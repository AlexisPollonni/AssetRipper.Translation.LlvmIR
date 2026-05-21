using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_3_fputil_FPBits_float128_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE3ENS0_6FPBitsIgEEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>::FPRepSem()")]
	public unsafe static void Invoke(fputil_internal_FPRepSem_f94eua* @this)
	{
		FPStorage_fputil_FPType_3_Constructor.Invoke(@this);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE3ENS0_6FPBitsIgEEECI2NS1_9FPStorageILS3_3EEEEo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>::FPRepSem(unsigned __int128)")]
	public unsafe static void Invoke(fputil_internal_FPRepSem_f94eua* @this, [MangledName(".coerce0")] long coerce0, [MangledName(".coerce1")] long coerce1)
	{
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = coerce0;
			((long*)(&@int))[1] = coerce1;
			Int128 int2 = @int;
			FPStorage_fputil_FPType_3_Constructor.Invoke(@this, *(long*)(&int2), ((long*)(&int2))[1]);
		}
	}
}
