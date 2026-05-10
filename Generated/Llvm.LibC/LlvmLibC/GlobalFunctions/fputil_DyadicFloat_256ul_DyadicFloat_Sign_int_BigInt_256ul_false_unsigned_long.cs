using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm256EEC2ENS_4SignEiNS_6BigIntILm256ELb0EmEE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>::DyadicFloat(__llvm_libc_20_1_2_::Sign, int, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>)")]
internal static partial class fputil_DyadicFloat_256ul_DyadicFloat_Sign_int_BigInt_256ul_false_unsigned_long
{
	public unsafe static void Invoke(void* @this, [MangledName("s.coerce")] sbyte s, int e, void* m)
	{
		anon_izyfb7 anon_izyfb8 = new anon_izyfb7
		{
			val = s
		};
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_jhcpjj*)@this)->sign, &anon_izyfb8, 1L, isVolatile: false);
			((fputil_DyadicFloat_jhcpjj*)@this)->exponent = e;
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_jhcpjj*)@this)->mantissa, m, 32L, isVolatile: false);
			fputil_DyadicFloat_256ul_normalize.Invoke(@this);
		}
	}
}
