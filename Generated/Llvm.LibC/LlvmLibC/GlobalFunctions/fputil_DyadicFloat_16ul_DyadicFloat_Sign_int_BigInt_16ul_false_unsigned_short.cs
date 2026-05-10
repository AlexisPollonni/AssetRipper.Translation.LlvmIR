using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm16EEC2ENS_4SignEiNS_6BigIntILm16ELb0EtEE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<16ul>::DyadicFloat(__llvm_libc_20_1_2_::Sign, int, __llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>)")]
internal static partial class fputil_DyadicFloat_16ul_DyadicFloat_Sign_int_BigInt_16ul_false_unsigned_short
{
	public unsafe static void Invoke(void* @this, [MangledName("s.coerce")] sbyte s, int e, [MangledName("m.coerce")] short m)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_ys7s55 bigInt_ys7s = default(BigInt_ys7s55);
		anon_izyfb8.val = s;
		unchecked
		{
			*(short*)(&bigInt_ys7s.val.Data) = m;
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_jvghxm*)@this)->sign, &anon_izyfb8, 1L, isVolatile: false);
			((fputil_DyadicFloat_jvghxm*)@this)->exponent = e;
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_jvghxm*)@this)->mantissa, &bigInt_ys7s, 2L, isVolatile: false);
			fputil_DyadicFloat_16ul_normalize.Invoke(@this);
		}
	}
}
