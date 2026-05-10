using System;
using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE4ENS0_6FPBitsIeEEEC2Eo")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::FPRepImpl(unsigned __int128)")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_FPRepImpl_unsigned_int128
{
	public unsafe static void Invoke(void* @this, [MangledName("x.coerce0")] long x, [MangledName("x.coerce1")] long x_coerce1)
	{
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = x;
			((long*)(&@int))[1] = x_coerce1;
			Int128 int2 = @int;
			fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_FPRepSem_unsigned_int128.Invoke(@this, *(long*)(&int2), ((long*)(&int2))[1]);
		}
	}
}
