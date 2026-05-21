using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_log_range_reduction
{
	[MangledName("_ZN19__llvm_libc_20_1_2_19log_range_reductionEdRKNS_5LogRRERNS_6fputil11DyadicFloatILm128EEE")]
	[DemangledName("__llvm_libc_20_1_2_::log_range_reduction(double, __llvm_libc_20_1_2_::LogRR const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>&)")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* Agg_result, [MangledName("m_x")][NativeType("double")] double M_x, [MangledName("log_table")][NativeType("__llvm_libc_20_1_2_::LogRR const&")] Llvm_libc_20_1_2_LogRR* Log_table, [MangledName("sum")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>&")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* Sum)
	{
		long num = 0L;
		long num2 = 0L;
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		long num8 = 0L;
		long num9 = 0L;
		Int128 y = default(Int128);
		Int128 @int = default(Int128);
		long num10 = 0L;
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Int128 x = default(Int128);
		Int128 x2 = default(Int128);
		Int128 y2 = default(Int128);
		Int128 int2 = default(Int128);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		InlineArray2_Int64 inlineArray2_Int = default(InlineArray2_Int64);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh2 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		InlineArray2_Int64 inlineArray2_Int2 = default(InlineArray2_Int64);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked((long)(M_x * 1.152921504606847E+18));
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = num + 4538783999459328L >> 46;
		Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2, Sum, 24L, isVolatile: false);
		unchecked
		{
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3, (byte*)(&Log_table->Step_2) + (nint)num2 * sizeof(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3);
			Llvm_memcpy_p0_p0_i64.Invoke(Sum, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, 24L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			long num11 = num2;
			num3 = ((int*)Llvm_libc_20_1_2_S2.Pointer)[num11];
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
		}
		num4 = num3 * num;
		Llvm_lifetime_start_p0.Invoke(8L, &num5);
		num5 = (num3 << 44) + num;
		Llvm_lifetime_start_p0.Invoke(8L, &num6);
		num6 = (num5 << 16) + num4;
		Llvm_lifetime_start_p0.Invoke(8L, &num7);
		num7 = num6 + 2900318160026599424L >> 55;
		Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5, Sum, 24L, isVolatile: false);
		unchecked
		{
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6, (byte*)(&Log_table->Step_3) + (nint)num7 * sizeof(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6);
			Llvm_memcpy_p0_p0_i64.Invoke(Sum, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, 24L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
			Llvm_lifetime_start_p0.Invoke(8L, &num8);
			long num12 = num7;
			num8 = ((int*)Llvm_libc_20_1_2_S3.Pointer)[num12];
			Llvm_lifetime_start_p0.Invoke(8L, &num9);
		}
		num9 = (num8 << 55) + num6;
		Llvm_lifetime_start_p0.Invoke(16L, &y);
		y = NumericHelper.MultiplySigned((Int128)num8, (Int128)num6);
		Llvm_lifetime_start_p0.Invoke(16L, &@int);
		@int = NumericHelper.AddSigned(NumericHelper.ShiftLeft((Int128)num9, (Int128)21L), y);
		Llvm_lifetime_start_p0.Invoke(8L, &num10);
		num10 = unchecked((int)NumericHelper.ShiftRightArithmetic(@int, 68L)) + 131 >> 1;
		Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8, Sum, 24L, isVolatile: false);
		unchecked
		{
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9, (byte*)(&Log_table->Step_4) + (nint)num10 * sizeof(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9);
			Llvm_memcpy_p0_p0_i64.Invoke(Sum, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, 24L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7);
			Llvm_lifetime_start_p0.Invoke(16L, &x);
			long num13 = num10;
			x = ((int*)Llvm_libc_20_1_2_S4.Pointer)[num13];
			Llvm_lifetime_start_p0.Invoke(16L, &x2);
			x2 = NumericHelper.AddSigned(NumericHelper.ShiftLeft(x, 69L), @int);
			Llvm_lifetime_start_p0.Invoke(16L, &y2);
			y2 = NumericHelper.MultiplySigned(x, @int);
			Llvm_lifetime_start_p0.Invoke(16L, &int2);
			int2 = NumericHelper.AddSigned(NumericHelper.ShiftLeft(x2, 28L), y2);
			bool num14 = NumericHelper.IntCmpSlt(int2, 0L);
			Llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Int);
			Llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Int2);
			if (num14)
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
				*(long*)(&inlineArray2_Int) = (long)NumericHelper.SubtractSigned(y: int2, x: 0L);
				((long*)(&inlineArray2_Int))[1] = (long)NumericHelper.ShiftRightArithmetic(NumericHelper.SubtractSigned(y: int2, x: 0L), 64L);
				BigInt_128ul_false_unsigned_long_BigInt_2ul.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), &inlineArray2_Int);
				DyadicFloat_128ul_Constructor.Invoke(Agg_result, anon_izyfb.Val, -125, *(long*)(&llvm_libc_20_1_2_BigInt_qdkjbh), ((long*)(&llvm_libc_20_1_2_BigInt_qdkjbh))[1]);
			}
			else
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				*(long*)(&inlineArray2_Int2) = (long)int2;
				((long*)(&inlineArray2_Int2))[1] = (long)NumericHelper.ShiftRightArithmetic(int2, 64L);
				BigInt_128ul_false_unsigned_long_BigInt_2ul.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2), &inlineArray2_Int2);
				DyadicFloat_128ul_Constructor.Invoke(Agg_result, anon_izyfb2.Val, -125, *(long*)(&llvm_libc_20_1_2_BigInt_qdkjbh2), ((long*)(&llvm_libc_20_1_2_BigInt_qdkjbh2))[1]);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Int2);
			Llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Int);
			Llvm_lifetime_end_p0.Invoke(16L, &int2);
			Llvm_lifetime_end_p0.Invoke(16L, &y2);
			Llvm_lifetime_end_p0.Invoke(16L, &x2);
			Llvm_lifetime_end_p0.Invoke(16L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &num10);
			Llvm_lifetime_end_p0.Invoke(16L, &@int);
			Llvm_lifetime_end_p0.Invoke(16L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &num9);
			Llvm_lifetime_end_p0.Invoke(8L, &num8);
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
