using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIeEC2IoEET_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<long double>::FPBits<unsigned __int128>(unsigned __int128)")]
internal static partial class fputil_FPBits_long_double_FPBits_unsigned_int128_unsigned_int128
{
	public unsafe static void Invoke(void* @this, [MangledName("x.coerce0")] long x, [MangledName("x.coerce1")] long x_coerce1)
	{
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = x;
			((long*)(&@int))[1] = x_coerce1;
			Int128 field_ = @int;
			fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_FPRepImpl.Invoke(@this);
			((fputil_internal_FPStorage_w3h7gw*)@this)->field_0 = field_;
		}
	}
}
