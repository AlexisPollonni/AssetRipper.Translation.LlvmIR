using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE11Significand13bits_all_onesEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand::bits_all_ones()")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_3_Significand_bits_all_ones
{
	public unsafe static Struct_fiz2nb Invoke()
	{
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(fputil_internal_FPRepSem_f94eua);
		Int128 @int = -1L;
		unchecked
		{
			fputil_internal_FPStorage_fputil_FPType_3_Significand_Significand_unsigned_int128.Invoke(&fputil_internal_FPRepSem_f94eua2, *(long*)(&@int), ((long*)(&@int))[1]);
			return *(Struct_fiz2nb*)(&fputil_internal_FPRepSem_f94eua2.FPStorage.field_0);
		}
	}
}
