using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_float_0_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIfLi0EEC2Ef")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<float, 0>::FloatToString(float)")]
	public unsafe static void Invoke(FloatToString_vnf553* @this, [NativeType("float")] float init_float)
	{
		FPBits_float_Constructor.Invoke(&@this->float_bits, init_float);
		unchecked
		{
			@this->exponent = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_explicit_exponent.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&@this->float_bits));
			@this->mantissa = (Int128)(UInt128)(uint)FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&@this->float_bits);
		}
		@this->exponent -= 23;
	}
}
