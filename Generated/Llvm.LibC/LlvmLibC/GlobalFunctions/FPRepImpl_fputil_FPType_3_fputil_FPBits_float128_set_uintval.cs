using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_set_uintval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE3ENS0_6FPBitsIgEEE11set_uintvalEo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>::set_uintval(unsigned __int128)")]
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
