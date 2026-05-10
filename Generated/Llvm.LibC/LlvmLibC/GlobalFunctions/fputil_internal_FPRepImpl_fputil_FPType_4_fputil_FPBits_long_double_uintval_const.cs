using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE4ENS0_6FPBitsIeEEE7uintvalEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::uintval() const")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval_const
{
	public unsafe static Struct_fiz2nb Invoke(void* @this)
	{
		unchecked
		{
			Int128 @int = NumericHelper.BitwiseAnd(((fputil_internal_FPStorage_w3h7gw*)@this)->field_0, -1L);
			return *(Struct_fiz2nb*)(&@int);
		}
	}
}
