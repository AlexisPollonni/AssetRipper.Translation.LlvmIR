using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EEC2ENS_4SignEiNS_6BigIntILm128ELb0EmEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::DyadicFloat(__llvm_libc_20_1_2_::Sign, int, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>)")]
	public unsafe static void Invoke(fputil_DyadicFloat_kt2kd4* @this, [MangledName("s.coerce")] sbyte s, int e, [MangledName("m.coerce0")] long m, [MangledName("m.coerce1")] long m_coerce1)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		anon_izyfb8.val = s;
		unchecked
		{
			*(long*)(&bigInt_qdkjbh) = m;
			((long*)(&bigInt_qdkjbh))[1] = m_coerce1;
			llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
			@this->exponent = e;
			llvm_memcpy_p0_p0_i64.Invoke(&@this->mantissa, &bigInt_qdkjbh, 16L, isVolatile: false);
			DyadicFloat_128ul_normalize.Invoke(@this);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::DyadicFloat()")]
	public unsafe static void Invoke(fputil_DyadicFloat_kt2kd4* @this)
	{
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, Sign_POS.Pointer, 1L, isVolatile: false);
		@this->exponent = 0;
		BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke(unchecked((anon_izyfb7*)(&@this->mantissa)), 0);
	}
}
