using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm32EEC2ENS_4SignEiNS_6BigIntILm32ELb0EjEE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<32ul>::DyadicFloat(__llvm_libc_20_1_2_::Sign, int, __llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>)")]
internal static partial class fputil_DyadicFloat_32ul_DyadicFloat_Sign_int_BigInt_32ul_false_unsigned_int
{
	public unsafe static void Invoke(void* @this, [MangledName("s.coerce")] sbyte s, int e, [MangledName("m.coerce")] int m)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_fzjdu3 bigInt_fzjdu = default(BigInt_fzjdu3);
		anon_izyfb8.val = s;
		unchecked
		{
			*(int*)(&bigInt_fzjdu.val.Data) = m;
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_c8qpxg*)@this)->sign, &anon_izyfb8, 1L, isVolatile: false);
			((fputil_DyadicFloat_c8qpxg*)@this)->exponent = e;
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_c8qpxg*)@this)->mantissa, &bigInt_fzjdu, 4L, isVolatile: false);
			fputil_DyadicFloat_32ul_normalize.Invoke(@this);
		}
	}
}
