using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Significand_bits_all_ones_zq7pq6
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE11Significand13bits_all_onesEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand::bits_all_ones()")]
	[CleanName("Significand_bits_all_ones")]
	public unsafe static Struct_fiz2nb Invoke()
	{
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua);
		Int128 @int = -1L;
		unchecked
		{
			Significand_Constructor_rhfmvq.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua, *(long*)(&@int), ((long*)(&@int))[1]);
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua.FPStorage.field_0);
		}
	}
}
