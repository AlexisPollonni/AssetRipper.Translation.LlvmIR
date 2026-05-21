using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_binary_exp_to_float_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal19binary_exp_to_floatIeEENS0_18FloatConvertReturnIT_EENS0_13ExpandedFloatIS3_EEbNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<long double> __llvm_libc_20_1_2_::internal::binary_exp_to_float<long double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>, bool, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::internal::FloatConvertReturn<long double>")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_internal_FloatConvertReturn_hgyipa* Agg_result, [MangledName("init_num")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>")] void* Init_num, [MangledName("truncated")][NativeType("bool")] bool Truncated, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		Int128 @int = default(Int128);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq llvm_libc_20_1_2_internal_ExpandedFloat_9jummq = default(Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
		int num5 = 0;
		Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
		Int128 int2 = default(Int128);
		Int128 y = default(Int128);
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
		sbyte b4 = (Truncated ? ((sbyte)1) : ((sbyte)0));
		Llvm_lifetime_start_p0.Invoke(16L, &@int);
		unchecked
		{
			@int = ((Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq*)Init_num)->Mantissa;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = ((Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq*)Init_num)->Exponent;
			Llvm_memset_p0_i64.Invoke(Agg_result, -86, 48L, isVolatile: false);
			FloatConvertReturn_long_double_Constructor.Invoke(Agg_result);
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = 32767;
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			Int128 int3 = @int;
			num3 = Cpp_countl_zero_unsigned_int128.Invoke(*(long*)(&int3), ((long*)(&int3))[1]);
			@int = NumericHelper.ShiftLeft(@int, (Int128)(UInt128)(uint)num3);
			num -= num3;
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = checked(num + 128 + 16383 - 1);
			if (num4 >= 32767)
			{
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
				Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_ExpandedFloat_9jummq, 0, 32L, isVolatile: false);
				_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq.Mantissa;
				llvm_libc_20_1_2_internal_ExpandedFloat_9jummq.Exponent = 32767;
				Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq, 32L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
				Agg_result->Error = 34;
				goto IL_0543;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = 64;
			if (num4 <= 0)
			{
				num5 += checked(1 - num4);
				num4 = 0;
				if ((uint)num5 > 128u)
				{
					Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2);
					Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2, 0, 32L, isVolatile: false);
					_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2.Mantissa;
					_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2.Exponent;
					Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2, 32L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2);
					Agg_result->Error = 34;
					goto IL_0531;
				}
			}
			Llvm_lifetime_start_p0.Invoke(16L, &int2);
			int2 = NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)(num5 - 1), x: 1L);
			Llvm_lifetime_start_p0.Invoke(16L, &y);
			y = NumericHelper.Subtract(int2, 1L);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(@int, int2), 0L) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = (sbyte)(byte)((!NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(@int, y), 0L)) ? (((b4 & 1) == 1) ? 1 : 0) : (-1));
			if ((uint)num5 < 128u)
			{
				@int = NumericHelper.ShiftRightLogical(@int, (Int128)(UInt128)(uint)num5);
				@int = NumericHelper.BitwiseAnd(@int, long.MaxValue);
			}
			else
			{
				@int = 0L;
			}
			Llvm_lifetime_start_p0.Invoke(1L, &b3);
			b3 = (NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(@int, 1L), 0L) ? ((sbyte)1) : ((sbyte)0));
			switch (Round)
			{
			case RoundDirection_b3pcwy.Nearest:
				if ((b & 1) == 1 && ((b3 & 1) == 1 || (b2 & 1) == 1))
				{
					@int = NumericHelper.Add(@int, 1L);
				}
				break;
			case RoundDirection_b3pcwy.Up:
				if ((b & 1) == 1 || (b2 & 1) == 1)
				{
					@int = NumericHelper.Add(@int, 1L);
				}
				break;
			default:
				if ((b & 1) == 1 && (b2 & 1) == 1)
				{
					@int = NumericHelper.Add(@int, 1L);
				}
				break;
			}
		}
		if (NumericHelper.IntCmpUgt(@int, long.MaxValue))
		{
			num4++;
			if (num4 == 32767)
			{
				Agg_result->Error = 34;
			}
		}
		if (num4 == 0)
		{
			Agg_result->Error = 34;
		}
		Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3);
		llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3.Mantissa = NumericHelper.BitwiseAnd(@int, long.MaxValue);
		llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3.Exponent = num4;
		Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3, 32L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3);
		Llvm_lifetime_end_p0.Invoke(1L, &b3);
		Llvm_lifetime_end_p0.Invoke(1L, &b2);
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		Llvm_lifetime_end_p0.Invoke(16L, &y);
		Llvm_lifetime_end_p0.Invoke(16L, &int2);
		goto IL_0531;
		IL_0531:
		Llvm_lifetime_end_p0.Invoke(4L, &num5);
		goto IL_0543;
		IL_0543:
		Llvm_lifetime_end_p0.Invoke(4L, &num4);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(16L, &@int);
	}
}
