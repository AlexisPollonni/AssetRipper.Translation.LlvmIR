using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE4ENS0_6FPBitsIeEEE12get_mantissaEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::get_mantissa() const")]
	public unsafe static Struct_fiz2nb Invoke(void* @this)
	{
		unchecked
		{
			Int128 @int = NumericHelper.BitwiseAnd(((fputil_internal_FPStorage_w3h7gw*)@this)->field_0, long.MaxValue);
			return *(Struct_fiz2nb*)(&@int);
		}
	}
}
