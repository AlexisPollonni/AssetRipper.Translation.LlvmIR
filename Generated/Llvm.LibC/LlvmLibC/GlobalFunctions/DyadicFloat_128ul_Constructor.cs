using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EEC2ENS_4SignEiNS_6BigIntILm128ELb0EmEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::DyadicFloat(__llvm_libc_20_1_2_::Sign, int, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* This, [MangledName("s.coerce")] sbyte S, [MangledName("e")] int E, [MangledName("m.coerce0")] long M, [MangledName("m.coerce1")] long M_coerce1)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		anon_izyfb.Val = S;
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_BigInt_qdkjbh) = M;
			((long*)(&llvm_libc_20_1_2_BigInt_qdkjbh))[1] = M_coerce1;
			Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
			This->Exponent = E;
			Llvm_memcpy_p0_p0_i64.Invoke(&This->Mantissa, &llvm_libc_20_1_2_BigInt_qdkjbh, 16L, isVolatile: false);
			DyadicFloat_128ul_normalize.Invoke(This);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::DyadicFloat()")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* This)
	{
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
		This->Exponent = 0;
		BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke(unchecked((Anon_izyfb7*)(&This->Mantissa)), 0);
	}
}
