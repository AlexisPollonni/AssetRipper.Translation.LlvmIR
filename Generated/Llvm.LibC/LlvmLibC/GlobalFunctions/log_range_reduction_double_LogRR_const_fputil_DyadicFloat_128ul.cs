using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_19log_range_reductionEdRKNS_5LogRRERNS_6fputil11DyadicFloatILm128EEE")]
[DemangledName("__llvm_libc_20_1_2_::log_range_reduction(double, __llvm_libc_20_1_2_::LogRR const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>&)")]
internal static partial class log_range_reduction_double_LogRR_const_fputil_DyadicFloat_128ul
{
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, double m_x, void* log_table, void* sum)
	{
		long num = 0L;
		long num2 = 0L;
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(fputil_DyadicFloat_kt2kd4);
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd8 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd9 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd10 = default(fputil_DyadicFloat_kt2kd4);
		long num8 = 0L;
		long num9 = 0L;
		Int128 y = default(Int128);
		Int128 @int = default(Int128);
		long num10 = 0L;
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd11 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd12 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd13 = default(fputil_DyadicFloat_kt2kd4);
		Int128 x = default(Int128);
		Int128 x2 = default(Int128);
		Int128 y2 = default(Int128);
		Int128 int2 = default(Int128);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		InlineArray2_Int64 inlineArray2_Int = default(InlineArray2_Int64);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		InlineArray2_Int64 inlineArray2_Int2 = default(InlineArray2_Int64);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked((long)(m_x * 1.152921504606847E+18));
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = num + 4538783999459328L >> 46;
		llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd6, sum, 24L, isVolatile: false);
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd7, (byte*)(&((LogRR*)log_table)->step_2) + (nint)num2 * sizeof(fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd5, &fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd7);
			llvm_memcpy_p0_p0_i64.Invoke(sum, &fputil_DyadicFloat_kt2kd5, 24L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			long num11 = num2;
			num3 = ((int*)S2.Pointer)[num11];
			llvm_lifetime_start_p0.Invoke(8L, &num4);
		}
		num4 = num3 * num;
		llvm_lifetime_start_p0.Invoke(8L, &num5);
		num5 = (num3 << 44) + num;
		llvm_lifetime_start_p0.Invoke(8L, &num6);
		num6 = (num5 << 16) + num4;
		llvm_lifetime_start_p0.Invoke(8L, &num7);
		num7 = num6 + 2900318160026599424L >> 55;
		llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd9, sum, 24L, isVolatile: false);
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd10, (byte*)(&((LogRR*)log_table)->step_3) + (nint)num7 * sizeof(fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd9, &fputil_DyadicFloat_kt2kd10);
			llvm_memcpy_p0_p0_i64.Invoke(sum, &fputil_DyadicFloat_kt2kd8, 24L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			long num12 = num7;
			num8 = ((int*)S3.Pointer)[num12];
			llvm_lifetime_start_p0.Invoke(8L, &num9);
		}
		num9 = (num8 << 55) + num6;
		llvm_lifetime_start_p0.Invoke(16L, &y);
		y = NumericHelper.MultiplySigned((Int128)num8, (Int128)num6);
		llvm_lifetime_start_p0.Invoke(16L, &@int);
		@int = NumericHelper.AddSigned(NumericHelper.ShiftLeft((Int128)num9, (Int128)21L), y);
		llvm_lifetime_start_p0.Invoke(8L, &num10);
		num10 = unchecked((int)NumericHelper.ShiftRightArithmetic(@int, 68L)) + 131 >> 1;
		llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd12, sum, 24L, isVolatile: false);
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd13, (byte*)(&((LogRR*)log_table)->step_4) + (nint)num10 * sizeof(fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd13);
			llvm_memcpy_p0_p0_i64.Invoke(sum, &fputil_DyadicFloat_kt2kd11, 24L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
			llvm_lifetime_start_p0.Invoke(16L, &x);
			long num13 = num10;
			x = ((int*)S4.Pointer)[num13];
			llvm_lifetime_start_p0.Invoke(16L, &x2);
			x2 = NumericHelper.AddSigned(NumericHelper.ShiftLeft(x, 69L), @int);
			llvm_lifetime_start_p0.Invoke(16L, &y2);
			y2 = NumericHelper.MultiplySigned(x, @int);
			llvm_lifetime_start_p0.Invoke(16L, &int2);
			int2 = NumericHelper.AddSigned(NumericHelper.ShiftLeft(x2, 28L), y2);
			bool num14 = NumericHelper.IntCmpSlt(int2, 0L);
			llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Int);
			llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Int2);
			if (num14)
			{
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_NEG.Pointer, 1L, isVolatile: false);
				*(long*)(&inlineArray2_Int) = (long)NumericHelper.SubtractSigned(y: int2, x: 0L);
				((long*)(&inlineArray2_Int))[1] = (long)NumericHelper.ShiftRightArithmetic(NumericHelper.SubtractSigned(y: int2, x: 0L), 64L);
				BigInt_128ul_false_unsigned_long_BigInt_2ul_unsigned_long_const_2ul.Invoke(&bigInt_qdkjbh, &inlineArray2_Int);
				fputil_DyadicFloat_128ul_DyadicFloat_Sign_int_BigInt_128ul_false_unsigned_long.Invoke(agg_result, anon_izyfb8.val, -125, *(long*)(&bigInt_qdkjbh), ((long*)(&bigInt_qdkjbh))[1]);
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				*(long*)(&inlineArray2_Int2) = (long)int2;
				((long*)(&inlineArray2_Int2))[1] = (long)NumericHelper.ShiftRightArithmetic(int2, 64L);
				BigInt_128ul_false_unsigned_long_BigInt_2ul_unsigned_long_const_2ul.Invoke(&bigInt_qdkjbh2, &inlineArray2_Int2);
				fputil_DyadicFloat_128ul_DyadicFloat_Sign_int_BigInt_128ul_false_unsigned_long.Invoke(agg_result, anon_izyfb9.val, -125, *(long*)(&bigInt_qdkjbh2), ((long*)(&bigInt_qdkjbh2))[1]);
			}
			llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Int2);
			llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Int);
			llvm_lifetime_end_p0.Invoke(16L, &int2);
			llvm_lifetime_end_p0.Invoke(16L, &y2);
			llvm_lifetime_end_p0.Invoke(16L, &x2);
			llvm_lifetime_end_p0.Invoke(16L, &x);
			llvm_lifetime_end_p0.Invoke(8L, &num10);
			llvm_lifetime_end_p0.Invoke(16L, &@int);
			llvm_lifetime_end_p0.Invoke(16L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &num9);
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
