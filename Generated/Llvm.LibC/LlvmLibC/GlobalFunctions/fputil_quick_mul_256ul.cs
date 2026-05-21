using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_quick_mul_256ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9quick_mulILm256EEENS0_11DyadicFloatIXT_EEERKS3_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul> __llvm_libc_20_1_2_::fputil::quick_mul<256ul>(__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<256ul> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>")]
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_jhcpjj* agg_result, [NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul> const&")] fputil_DyadicFloat_jhcpjj* a, [NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul> const&")] fputil_DyadicFloat_jhcpjj* b)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		BigInt_x9dsed bigInt_x9dsed = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed2 = default(BigInt_x9dsed);
		llvm_memset_p0_i64.Invoke(agg_result, -86, 40L, isVolatile: false);
		DyadicFloat_256ul_Constructor.Invoke(agg_result);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &a->sign, 1L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &b->sign, 1L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(source: (!NotEquals_rpctvi.Invoke(anon_izyfb8.val, anon_izyfb9.val)) ? Sign_POS.Pointer : Sign_NEG.Pointer, destination: &agg_result->sign, length: 1L, isVolatile: false);
		agg_result->exponent = a->exponent + b->exponent + 256;
		if (!BigInt_256ul_false_unsigned_long_is_zero.Invoke(&a->mantissa) && !BigInt_256ul_false_unsigned_long_is_zero.Invoke(&b->mantissa))
		{
			llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed);
			BigInt_256ul_false_unsigned_long_quick_mul_hi.Invoke(&bigInt_x9dsed, &a->mantissa, &b->mantissa);
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->mantissa, &bigInt_x9dsed, 32L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed);
			if (*unchecked((long*)array_unsigned_long_4ul_Index_6jyt8f.Invoke(&agg_result->mantissa.val, 3L)) >>> 63 == 0L)
			{
				DyadicFloat_256ul_shift_left.Invoke(agg_result, 1);
			}
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed2);
			BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_x9dsed2, 0);
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->mantissa, &bigInt_x9dsed2, 32L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed2);
		}
	}
}
