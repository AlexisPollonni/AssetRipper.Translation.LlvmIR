using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_256ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm256EEC2ENS_4SignEiNS_6BigIntILm256ELb0EmEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>::DyadicFloat(__llvm_libc_20_1_2_::Sign, int, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_DyadicFloat_jhcpjj* This, [MangledName("s.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte S, [MangledName("e")][NativeType("int")] int E, [MangledName("m")][NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>")] void* M)
	{
		Anon_izyfb7 anon_izyfb = new Anon_izyfb7
		{
			Val = S
		};
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
		This->Exponent = E;
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Mantissa, M, 32L, isVolatile: false);
		DyadicFloat_256ul_normalize.Invoke(This);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm256EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>::DyadicFloat()")]
	public unsafe static void Invoke([MangledName("this")] Fputil_DyadicFloat_jhcpjj* This)
	{
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, Sign_POS.Pointer, 1L, isVolatile: false);
		This->Exponent = 0;
		BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&This->Mantissa, 0);
	}
}
