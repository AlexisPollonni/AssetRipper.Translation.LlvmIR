using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_quick_add_128ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9quick_addILm128EEENS0_11DyadicFloatIXT_EEES3_S3_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> __llvm_libc_20_1_2_::fputil::quick_add<128ul>(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>")]
	public unsafe static void Invoke([MangledName("agg.result")] Fputil_DyadicFloat_kt2kd4* Agg_result, [MangledName("a")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>")] void* A, [MangledName("b")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>")] void* B)
	{
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke(BigInt_128ul_false_unsigned_long_is_zero.Invoke((Anon_izyfb7*)(&((Fputil_DyadicFloat_kt2kd4*)A)->Mantissa)), Expected: false))
			{
				Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, B, 24L, isVolatile: false);
				return;
			}
			if (Details_expects_bool_condition_bool.Invoke(BigInt_128ul_false_unsigned_long_is_zero.Invoke((Anon_izyfb7*)(&((Fputil_DyadicFloat_kt2kd4*)B)->Mantissa)), Expected: false))
			{
				Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, A, 24L, isVolatile: false);
				return;
			}
			if (((Fputil_DyadicFloat_kt2kd4*)A)->Exponent > ((Fputil_DyadicFloat_kt2kd4*)B)->Exponent)
			{
				DyadicFloat_128ul_shift_right.Invoke((Fputil_DyadicFloat_kt2kd4*)B, checked(unchecked((Fputil_DyadicFloat_kt2kd4*)A)->Exponent - unchecked((Fputil_DyadicFloat_kt2kd4*)B)->Exponent));
			}
			else if (((Fputil_DyadicFloat_kt2kd4*)B)->Exponent > ((Fputil_DyadicFloat_kt2kd4*)A)->Exponent)
			{
				DyadicFloat_128ul_shift_right.Invoke((Fputil_DyadicFloat_kt2kd4*)A, checked(unchecked((Fputil_DyadicFloat_kt2kd4*)B)->Exponent - unchecked((Fputil_DyadicFloat_kt2kd4*)A)->Exponent));
			}
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd))[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			DyadicFloat_128ul_Constructor.Invoke(&fputil_DyadicFloat_kt2kd);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &((Fputil_DyadicFloat_kt2kd4*)A)->Sign, 1L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &((Fputil_DyadicFloat_kt2kd4*)B)->Sign, 1L, isVolatile: false);
			if (Equals_fy8fvt.Invoke(anon_izyfb.Val, anon_izyfb2.Val))
			{
				Llvm_memcpy_p0_p0_i64.Invoke(source: &((Fputil_DyadicFloat_kt2kd4*)A)->Sign, destination: &fputil_DyadicFloat_kt2kd.Sign, length: 1L, isVolatile: false);
				fputil_DyadicFloat_kt2kd.Exponent = ((Fputil_DyadicFloat_kt2kd4*)A)->Exponent;
				Llvm_memcpy_p0_p0_i64.Invoke(source: &((Fputil_DyadicFloat_kt2kd4*)A)->Mantissa, destination: &fputil_DyadicFloat_kt2kd.Mantissa, length: 16L, isVolatile: false);
				if (BigInt_128ul_false_unsigned_long_add_overflow.Invoke((Anon_izyfb7*)(&fputil_DyadicFloat_kt2kd.Mantissa), (Anon_izyfb7*)(&((Fputil_DyadicFloat_kt2kd4*)B)->Mantissa)) != 0L)
				{
					DyadicFloat_128ul_shift_right.Invoke(&fputil_DyadicFloat_kt2kd, 1);
					*(long*)Array_unsigned_long_2ul_Index_6dk93t.Invoke(&fputil_DyadicFloat_kt2kd.Mantissa.Val, 1L) |= long.MinValue;
				}
				Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, &fputil_DyadicFloat_kt2kd, 24L, isVolatile: false);
			}
			else
			{
				if (GreaterThanOrEquals_crwxpm.Invoke((Anon_izyfb7*)(&((Fputil_DyadicFloat_kt2kd4*)A)->Mantissa), (Anon_izyfb7*)(&((Fputil_DyadicFloat_kt2kd4*)B)->Mantissa)))
				{
					Llvm_memcpy_p0_p0_i64.Invoke(source: &((Fputil_DyadicFloat_kt2kd4*)A)->Sign, destination: &fputil_DyadicFloat_kt2kd.Sign, length: 1L, isVolatile: false);
					fputil_DyadicFloat_kt2kd.Exponent = ((Fputil_DyadicFloat_kt2kd4*)A)->Exponent;
					Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
					Struct_fiz2nb struct_fiz2nb = BigInt_128ul_false_unsigned_long_Subtract_wqmyif.Invoke((Anon_izyfb7*)(&((Fputil_DyadicFloat_kt2kd4*)A)->Mantissa), (Anon_izyfb7*)(&((Fputil_DyadicFloat_kt2kd4*)B)->Mantissa));
					InlineArray2_Int64* ptr3 = &bigInt_qdkjbh.Val.Data;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb2.field_0;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb3.field_1;
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd.Mantissa, &bigInt_qdkjbh, 16L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
				}
				else
				{
					Llvm_memcpy_p0_p0_i64.Invoke(source: &((Fputil_DyadicFloat_kt2kd4*)B)->Sign, destination: &fputil_DyadicFloat_kt2kd.Sign, length: 1L, isVolatile: false);
					fputil_DyadicFloat_kt2kd.Exponent = ((Fputil_DyadicFloat_kt2kd4*)B)->Exponent;
					Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
					Struct_fiz2nb struct_fiz2nb4 = BigInt_128ul_false_unsigned_long_Subtract_wqmyif.Invoke((Anon_izyfb7*)(&((Fputil_DyadicFloat_kt2kd4*)B)->Mantissa), (Anon_izyfb7*)(&((Fputil_DyadicFloat_kt2kd4*)A)->Mantissa));
					InlineArray2_Int64* ptr4 = &bigInt_qdkjbh2.Val.Data;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb6.field_1;
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd.Mantissa, &bigInt_qdkjbh2, 16L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
				}
				Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, DyadicFloat_128ul_normalize.Invoke(&fputil_DyadicFloat_kt2kd), 24L, isVolatile: false);
			}
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
		}
	}
}
