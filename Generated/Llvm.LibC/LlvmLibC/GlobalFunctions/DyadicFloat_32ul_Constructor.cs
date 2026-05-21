using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_32ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm32EEC2ENS_4SignEiNS_6BigIntILm32ELb0EjEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<32ul>::DyadicFloat(__llvm_libc_20_1_2_::Sign, int, __llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("s.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte S, [MangledName("e")][NativeType("int")] int E, [MangledName("m.coerce")][NativeType("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>")] int M)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		anon_izyfb.Val = S;
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw.Val.Data) = M;
			Llvm_memcpy_p0_p0_i64.Invoke(&((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Sign, &anon_izyfb, 1L, isVolatile: false);
			((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Exponent = E;
			Llvm_memcpy_p0_p0_i64.Invoke(&((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Mantissa, &llvm_libc_20_1_2_BigInt_vtm4cw, 4L, isVolatile: false);
			DyadicFloat_32ul_normalize.Invoke(This);
		}
	}
}
