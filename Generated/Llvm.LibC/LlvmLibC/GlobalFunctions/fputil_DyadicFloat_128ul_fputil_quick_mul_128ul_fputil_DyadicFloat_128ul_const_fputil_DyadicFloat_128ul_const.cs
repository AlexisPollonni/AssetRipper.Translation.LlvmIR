using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9quick_mulILm128EEENS0_11DyadicFloatIXT_EEERKS3_S5_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> __llvm_libc_20_1_2_::fputil::quick_mul<128ul>(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&)")]
internal static partial class fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const
{
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, fputil_DyadicFloat_kt2kd4* a, fputil_DyadicFloat_kt2kd4* b)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		unchecked
		{
			*(sbyte*)agg_result = -86;
			sbyte* ptr = (sbyte*)agg_result + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)agg_result)[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)agg_result + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			fputil_DyadicFloat_128ul_DyadicFloat.Invoke(agg_result);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &a->sign, 1L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &b->sign, 1L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(source: (!operator_Sign_Sign_rpctvi.Invoke(anon_izyfb8.val, anon_izyfb9.val)) ? Sign_POS.Pointer : Sign_NEG.Pointer, destination: &agg_result->sign, length: 1L, isVolatile: false);
			agg_result->exponent = checked(a->exponent + b->exponent + 128);
			if (!BigInt_128ul_false_unsigned_long_is_zero_const.Invoke((anon_izyfb7*)(&a->mantissa)) && !BigInt_128ul_false_unsigned_long_is_zero_const.Invoke((anon_izyfb7*)(&b->mantissa)))
			{
				llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
				Struct_fiz2nb struct_fiz2nb = BigInt_128ul_false_unsigned_long_quick_mul_hi_BigInt_128ul_false_unsigned_long_const_const.Invoke((anon_izyfb7*)(&a->mantissa), (anon_izyfb7*)(&b->mantissa));
				InlineArray2_Int64* ptr3 = &bigInt_qdkjbh.val.Data;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb3.field_1;
				llvm_memcpy_p0_p0_i64.Invoke(&agg_result->mantissa, &bigInt_qdkjbh, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
				if (*(long*)cpp_array_unsigned_long_2ul_operator_unsigned_long.Invoke(&agg_result->mantissa.val, 1L) >>> 63 == 0L)
				{
					fputil_DyadicFloat_128ul_shift_left_unsigned_int.Invoke(agg_result, 1);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
				BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2), 0);
				llvm_memcpy_p0_p0_i64.Invoke(&agg_result->mantissa, &bigInt_qdkjbh2, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
			}
		}
	}
}
