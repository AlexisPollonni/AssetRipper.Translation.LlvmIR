using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EEC2ENS_4SignEiNS_6BigIntILm64ELb0EmEE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::DyadicFloat(__llvm_libc_20_1_2_::Sign, int, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>)")]
internal static partial class fputil_DyadicFloat_64ul_DyadicFloat_Sign_int_BigInt_64ul_false_unsigned_long
{
	public unsafe static void Invoke(fputil_DyadicFloat_syracv* @this, [MangledName("s.coerce")] sbyte s, int e, [MangledName("m.coerce")] long m)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		anon_izyfb8.val = s;
		*unchecked((long*)(&bigInt_555ggs.val.Data)) = m;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
		@this->exponent = e;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->mantissa, &bigInt_555ggs, 8L, isVolatile: false);
		fputil_DyadicFloat_64ul_normalize.Invoke(@this);
	}
}
