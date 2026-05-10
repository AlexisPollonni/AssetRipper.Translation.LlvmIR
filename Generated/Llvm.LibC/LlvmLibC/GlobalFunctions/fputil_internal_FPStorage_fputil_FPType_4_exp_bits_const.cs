using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE4EE8exp_bitsEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::exp_bits() const")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_4_exp_bits_const
{
	public unsafe static Struct_fiz2nb Invoke(void* @this)
	{
		unchecked
		{
			Int128 @int = NumericHelper.BitwiseAnd(((fputil_internal_FPStorage_w3h7gw*)@this)->field_0, 0L);
			return *(Struct_fiz2nb*)(&@int);
		}
	}
}
