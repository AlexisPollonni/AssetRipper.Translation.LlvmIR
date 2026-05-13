using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE4ENS0_6FPBitsIeEEE11set_uintvalEo")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::set_uintval(unsigned __int128)")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_uintval_unsigned_int128
{
	public unsafe static void Invoke(void* @this, [MangledName("value.coerce0")] long value, [MangledName("value.coerce1")] long value_coerce1)
	{
		Int128 x = default(Int128);
		unchecked
		{
			*(long*)(&x) = value;
			((long*)(&x))[1] = value_coerce1;
			((fputil_internal_FPStorage_w3h7gw*)@this)->field_0 = NumericHelper.BitwiseAnd(x, -1L);
		}
	}
}
