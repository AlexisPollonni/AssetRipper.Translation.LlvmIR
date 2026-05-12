using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIfLi0EEC2Ef")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<float, 0>::FloatToString(float)")]
internal static partial class FloatToString_float_0_FloatToString_float
{
	public unsafe static void Invoke(FloatToString_uyiqeh* @this, float init_float)
	{
		fputil_FPBits_float_FPBits_float_float.Invoke(&@this->float_bits, init_float);
		unchecked
		{
			@this->exponent = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_explicit_exponent_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&@this->float_bits));
			@this->mantissa = (Int128)(UInt128)(uint)fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa_const.Invoke(&@this->float_bits);
		}
		@this->exponent -= 23;
	}
}
