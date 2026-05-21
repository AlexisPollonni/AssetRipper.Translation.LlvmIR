using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_float_0_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIfLi0EEC2Ef")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<float, 0>::FloatToString(float)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_FloatToString_vnf553* This, [MangledName("init_float")][NativeType("float")] float Init_float)
	{
		FPBits_float_Constructor.Invoke(&This->Float_bits, Init_float);
		unchecked
		{
			This->Exponent = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_explicit_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&This->Float_bits));
			This->Mantissa = (Int128)(UInt128)(uint)FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&This->Float_bits);
		}
		This->Exponent -= 23;
	}
}
