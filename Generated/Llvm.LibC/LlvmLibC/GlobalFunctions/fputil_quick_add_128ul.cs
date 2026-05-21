using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_quick_add_128ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9quick_addILm128EEENS0_11DyadicFloatIXT_EEES3_S3_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> __llvm_libc_20_1_2_::fputil::quick_add<128ul>(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>")]
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, [NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>")] void* a, [NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>")] void* b)
	{
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		unchecked
		{
			if (details_expects_bool_condition_bool.Invoke(BigInt_128ul_false_unsigned_long_is_zero.Invoke((anon_izyfb7*)(&((fputil_DyadicFloat_kt2kd4*)a)->mantissa)), expected: false))
			{
				llvm_memcpy_p0_p0_i64.Invoke(agg_result, b, 24L, isVolatile: false);
				return;
			}
			if (details_expects_bool_condition_bool.Invoke(BigInt_128ul_false_unsigned_long_is_zero.Invoke((anon_izyfb7*)(&((fputil_DyadicFloat_kt2kd4*)b)->mantissa)), expected: false))
			{
				llvm_memcpy_p0_p0_i64.Invoke(agg_result, a, 24L, isVolatile: false);
				return;
			}
			if (((fputil_DyadicFloat_kt2kd4*)a)->exponent > ((fputil_DyadicFloat_kt2kd4*)b)->exponent)
			{
				DyadicFloat_128ul_shift_right.Invoke((fputil_DyadicFloat_kt2kd4*)b, checked(unchecked((fputil_DyadicFloat_kt2kd4*)a)->exponent - unchecked((fputil_DyadicFloat_kt2kd4*)b)->exponent));
			}
			else if (((fputil_DyadicFloat_kt2kd4*)b)->exponent > ((fputil_DyadicFloat_kt2kd4*)a)->exponent)
			{
				DyadicFloat_128ul_shift_right.Invoke((fputil_DyadicFloat_kt2kd4*)a, checked(unchecked((fputil_DyadicFloat_kt2kd4*)b)->exponent - unchecked((fputil_DyadicFloat_kt2kd4*)a)->exponent));
			}
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			DyadicFloat_128ul_Constructor.Invoke(&fputil_DyadicFloat_kt2kd5);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &((fputil_DyadicFloat_kt2kd4*)a)->sign, 1L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &((fputil_DyadicFloat_kt2kd4*)b)->sign, 1L, isVolatile: false);
			if (Equals_fy8fvt.Invoke(anon_izyfb8.val, anon_izyfb9.val))
			{
				llvm_memcpy_p0_p0_i64.Invoke(source: &((fputil_DyadicFloat_kt2kd4*)a)->sign, destination: &fputil_DyadicFloat_kt2kd5.sign, length: 1L, isVolatile: false);
				fputil_DyadicFloat_kt2kd5.exponent = ((fputil_DyadicFloat_kt2kd4*)a)->exponent;
				llvm_memcpy_p0_p0_i64.Invoke(source: &((fputil_DyadicFloat_kt2kd4*)a)->mantissa, destination: &fputil_DyadicFloat_kt2kd5.mantissa, length: 16L, isVolatile: false);
				if (BigInt_128ul_false_unsigned_long_add_overflow.Invoke((anon_izyfb7*)(&fputil_DyadicFloat_kt2kd5.mantissa), (anon_izyfb7*)(&((fputil_DyadicFloat_kt2kd4*)b)->mantissa)) != 0L)
				{
					DyadicFloat_128ul_shift_right.Invoke(&fputil_DyadicFloat_kt2kd5, 1);
					*(long*)array_unsigned_long_2ul_Index_6dk93t.Invoke(&fputil_DyadicFloat_kt2kd5.mantissa.val, 1L) |= long.MinValue;
				}
				llvm_memcpy_p0_p0_i64.Invoke(agg_result, &fputil_DyadicFloat_kt2kd5, 24L, isVolatile: false);
			}
			else
			{
				if (GreaterThanOrEquals_crwxpm.Invoke((anon_izyfb7*)(&((fputil_DyadicFloat_kt2kd4*)a)->mantissa), (anon_izyfb7*)(&((fputil_DyadicFloat_kt2kd4*)b)->mantissa)))
				{
					llvm_memcpy_p0_p0_i64.Invoke(source: &((fputil_DyadicFloat_kt2kd4*)a)->sign, destination: &fputil_DyadicFloat_kt2kd5.sign, length: 1L, isVolatile: false);
					fputil_DyadicFloat_kt2kd5.exponent = ((fputil_DyadicFloat_kt2kd4*)a)->exponent;
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
					Struct_fiz2nb struct_fiz2nb = BigInt_128ul_false_unsigned_long_Subtract_wqmyif.Invoke((anon_izyfb7*)(&((fputil_DyadicFloat_kt2kd4*)a)->mantissa), (anon_izyfb7*)(&((fputil_DyadicFloat_kt2kd4*)b)->mantissa));
					InlineArray2_Int64* ptr3 = &bigInt_qdkjbh.val.Data;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb2.field_0;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb3.field_1;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd5.mantissa, &bigInt_qdkjbh, 16L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
				}
				else
				{
					llvm_memcpy_p0_p0_i64.Invoke(source: &((fputil_DyadicFloat_kt2kd4*)b)->sign, destination: &fputil_DyadicFloat_kt2kd5.sign, length: 1L, isVolatile: false);
					fputil_DyadicFloat_kt2kd5.exponent = ((fputil_DyadicFloat_kt2kd4*)b)->exponent;
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
					Struct_fiz2nb struct_fiz2nb4 = BigInt_128ul_false_unsigned_long_Subtract_wqmyif.Invoke((anon_izyfb7*)(&((fputil_DyadicFloat_kt2kd4*)b)->mantissa), (anon_izyfb7*)(&((fputil_DyadicFloat_kt2kd4*)a)->mantissa));
					InlineArray2_Int64* ptr4 = &bigInt_qdkjbh2.val.Data;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb6.field_1;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd5.mantissa, &bigInt_qdkjbh2, 16L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
				}
				llvm_memcpy_p0_p0_i64.Invoke(agg_result, DyadicFloat_128ul_normalize.Invoke(&fputil_DyadicFloat_kt2kd5), 24L, isVolatile: false);
			}
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		}
	}
}
