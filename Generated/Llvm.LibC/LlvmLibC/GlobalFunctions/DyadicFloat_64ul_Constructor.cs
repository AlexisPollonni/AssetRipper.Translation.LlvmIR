using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_64ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EEC2ENS_4SignEiNS_6BigIntILm64ELb0EmEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::DyadicFloat(__llvm_libc_20_1_2_::Sign, int, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_DyadicFloat_syracv* This, [MangledName("s.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte S, [MangledName("e")][NativeType("int")] int E, [MangledName("m.coerce")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>")] long M)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		anon_izyfb.Val = S;
		*unchecked((long*)(&bigInt_555ggs.Val.Data)) = M;
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
		This->Exponent = E;
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Mantissa, &bigInt_555ggs, 8L, isVolatile: false);
		DyadicFloat_64ul_normalize.Invoke(This);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::DyadicFloat()")]
	public unsafe static void Invoke([MangledName("this")] Fputil_DyadicFloat_syracv* This)
	{
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, Sign_POS.Pointer, 1L, isVolatile: false);
		This->Exponent = 0;
		BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&This->Mantissa, 0);
	}
}
