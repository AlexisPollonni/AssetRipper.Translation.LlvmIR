using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_double_0_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIdLi0EEC2Ed")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<double, 0>::FloatToString(double)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("init_float")][NativeType("double")] double Init_float)
	{
		unchecked
		{
			FPBits_double_Constructor.Invoke(&((FloatToString_rwjwy3*)This)->Float_bits, Init_float);
			((FloatToString_rwjwy3*)This)->field_1 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_explicit_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&((FloatToString_rwjwy3*)This)->Float_bits));
			((FloatToString_rwjwy3*)This)->Mantissa = (Int128)(UInt128)(ulong)FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&((FloatToString_rwjwy3*)This)->Float_bits));
		}
		unchecked((FloatToString_rwjwy3*)This)->field_1 -= 52;
	}
}
