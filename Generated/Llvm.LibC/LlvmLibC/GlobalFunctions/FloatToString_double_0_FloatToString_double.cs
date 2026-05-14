using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIdLi0EEC2Ed")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<double, 0>::FloatToString(double)")]
internal static partial class FloatToString_double_0_FloatToString_double
{
	public unsafe static void Invoke(void* @this, double init_float)
	{
		unchecked
		{
			fputil_FPBits_double_FPBits_double_double.Invoke(&((FloatToString_rwjwy3*)@this)->float_bits, init_float);
			((FloatToString_rwjwy3*)@this)->field_1 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_explicit_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&((FloatToString_rwjwy3*)@this)->float_bits));
			((FloatToString_rwjwy3*)@this)->mantissa = (Int128)(UInt128)(ulong)fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&((FloatToString_rwjwy3*)@this)->float_bits));
		}
		unchecked((FloatToString_rwjwy3*)@this)->field_1 -= 52;
	}
}
