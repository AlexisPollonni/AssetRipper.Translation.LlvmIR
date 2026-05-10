using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE11Significand3msbEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand::msb()")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_3_Significand_msb
{
	public unsafe static Struct_fiz2nb Invoke()
	{
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(fputil_internal_FPRepSem_f94eua);
		Int128 @int = 0L;
		unchecked
		{
			fputil_internal_FPStorage_fputil_FPType_3_Significand_Significand_unsigned_int128.Invoke(&fputil_internal_FPRepSem_f94eua2, *(long*)(&@int), ((long*)(&@int))[1]);
			return *(Struct_fiz2nb*)(&fputil_internal_FPRepSem_f94eua2.FPStorage.field_0);
		}
	}
}
