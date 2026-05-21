using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Significand_msb_disqcp
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE4EE11Significand3msbEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::Significand::msb()")]
	[CleanName("Significand_msb")]
	public unsafe static Struct_fiz2nb Invoke()
	{
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua);
		Int128 @int = long.MinValue;
		unchecked
		{
			Significand_Constructor_j3ersh.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua, *(long*)(&@int), ((long*)(&@int))[1]);
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua.FPStorage.field_0);
		}
	}
}
