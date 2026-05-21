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
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(fputil_internal_FPRepSem_f94eua);
		Int128 @int = long.MinValue;
		unchecked
		{
			Significand_Constructor_j3ersh.Invoke(&fputil_internal_FPRepSem_f94eua2, *(long*)(&@int), ((long*)(&@int))[1]);
			return *(Struct_fiz2nb*)(&fputil_internal_FPRepSem_f94eua2.FPStorage.field_0);
		}
	}
}
