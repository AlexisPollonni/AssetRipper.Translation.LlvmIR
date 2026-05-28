using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_quick_mul_256ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9quick_mulILm256EEENS0_11DyadicFloatIXT_EEERKS3_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul> __llvm_libc_20_1_2_::fputil::quick_mul<256ul>(__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<256ul> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>")]
	public unsafe static void Invoke([MangledName("agg.result")] Fputil_DyadicFloat_jhcpjj* Agg_result, [MangledName("a")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul> const&")] Fputil_DyadicFloat_jhcpjj* A, [MangledName("b")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul> const&")] Fputil_DyadicFloat_jhcpjj* B)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		BigInt_x9dsed bigInt_x9dsed = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed2 = default(BigInt_x9dsed);
		Llvm_memset_p0_i64.Invoke(Agg_result, -86, 40L, isVolatile: false);
		DyadicFloat_256ul_Constructor.Invoke(Agg_result);
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &A->Sign, 1L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &B->Sign, 1L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(source: (!NotEquals_rpctvi.Invoke(anon_izyfb.Val, anon_izyfb2.Val)) ? Sign_POS.Pointer : Sign_NEG.Pointer, destination: &Agg_result->Sign, length: 1L, isVolatile: false);
		Agg_result->Exponent = A->Exponent + B->Exponent + 256;
		if (!BigInt_256ul_false_unsigned_long_is_zero.Invoke(&A->Mantissa) && !BigInt_256ul_false_unsigned_long_is_zero.Invoke(&B->Mantissa))
		{
			Llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed);
			BigInt_256ul_false_unsigned_long_quick_mul_hi.Invoke(&bigInt_x9dsed, &A->Mantissa, &B->Mantissa);
			Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Mantissa, &bigInt_x9dsed, 32L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed);
			if (*unchecked((long*)Array_unsigned_long_4ul_Index_6jyt8f.Invoke(&Agg_result->Mantissa.Val, 3L)) >>> 63 == 0L)
			{
				DyadicFloat_256ul_shift_left.Invoke(Agg_result, 1);
			}
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed2);
			BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_x9dsed2, 0);
			Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Mantissa, &bigInt_x9dsed2, 32L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed2);
		}
	}
}
