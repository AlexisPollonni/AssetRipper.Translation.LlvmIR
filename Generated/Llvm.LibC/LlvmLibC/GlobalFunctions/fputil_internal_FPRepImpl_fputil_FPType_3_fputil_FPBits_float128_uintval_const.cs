using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE3ENS0_6FPBitsIgEEE7uintvalEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>::uintval() const")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval_const
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
