using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_64ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EEC2ENS_4SignEiNS_6BigIntILm64ELb0EmEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::DyadicFloat(__llvm_libc_20_1_2_::Sign, int, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>)")]
	public unsafe static void Invoke(fputil_DyadicFloat_syracv* @this, [MangledName("s.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte s, [NativeType("int")] int e, [MangledName("m.coerce")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>")] long m)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		anon_izyfb8.val = s;
		*unchecked((long*)(&bigInt_555ggs.val.Data)) = m;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
		@this->exponent = e;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->mantissa, &bigInt_555ggs, 8L, isVolatile: false);
		DyadicFloat_64ul_normalize.Invoke(@this);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::DyadicFloat()")]
	public unsafe static void Invoke(fputil_DyadicFloat_syracv* @this)
	{
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, Sign_POS.Pointer, 1L, isVolatile: false);
		@this->exponent = 0;
		BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&@this->mantissa, 0);
	}
}
