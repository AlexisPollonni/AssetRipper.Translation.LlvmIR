using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Significand_zero_ayadik
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE4EE11Significand4zeroEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::Significand::zero()")]
	[CleanName("Significand_zero")]
	public unsafe static Struct_fiz2nb Invoke()
	{
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua);
		Int128 @int = 0L;
		unchecked
		{
			Significand_Constructor_j3ersh.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua, *(long*)(&@int), ((long*)(&@int))[1]);
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua.FPStorage.field_0);
		}
	}
}
