using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_16ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm16EEC2ENS_4SignEiNS_6BigIntILm16ELb0EtEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<16ul>::DyadicFloat(__llvm_libc_20_1_2_::Sign, int, __llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm* This, [MangledName("s.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte S, [MangledName("e")][NativeType("int")] int E, [MangledName("m.coerce")][NativeType("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>")] short M)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_ys7s55 llvm_libc_20_1_2_BigInt_ys7s = default(Llvm_libc_20_1_2_BigInt_ys7s55);
		anon_izyfb.Val = S;
		*unchecked((short*)(&llvm_libc_20_1_2_BigInt_ys7s.Val.Data)) = M;
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
		This->Exponent = E;
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Mantissa, &llvm_libc_20_1_2_BigInt_ys7s, 2L, isVolatile: false);
		DyadicFloat_16ul_normalize.Invoke(This);
	}
}
