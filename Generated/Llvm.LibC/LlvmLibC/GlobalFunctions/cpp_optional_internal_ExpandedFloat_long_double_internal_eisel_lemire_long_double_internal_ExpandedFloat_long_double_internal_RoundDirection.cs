using System;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal12eisel_lemireIeEENS_3cpp8optionalINS0_13ExpandedFloatIT_EEEES6_NS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>> __llvm_libc_20_1_2_::internal::eisel_lemire<long double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class cpp_optional_internal_ExpandedFloat_long_double_internal_eisel_lemire_long_double_internal_ExpandedFloat_long_double_internal_RoundDirection
{
	public unsafe static void Invoke([MangledName("agg.result")] cpp_optional_q5jaj8* agg_result, void* init_num, RoundDirection_b3pcwy round)
	{
		Int128 @int = default(Int128);
		int num = 0;
		int num2 = 0;
		Int128 int2 = default(Int128);
		int num3 = 0;
		void* ptr = null;
		Int128 x = default(Int128);
		Int128 int3 = default(Int128);
		Int128 y = default(Int128);
		Int128 x2 = default(Int128);
		Int128 int4 = default(Int128);
		Int128 x3 = default(Int128);
		Int128 x4 = default(Int128);
		Int128 int5 = default(Int128);
		int num4 = 0;
		Int128 int6 = default(Int128);
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq2 = default(internal_ExpandedFloat_9jummq);
		llvm_lifetime_start_p0.Invoke(16L, &@int);
		unchecked
		{
			@int = ((internal_ExpandedFloat_9jummq*)init_num)->mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = ((internal_ExpandedFloat_9jummq*)init_num)->exponent;
			if (num < -348 || num > 347)
			{
				cpp_optional_internal_ExpandedFloat_long_double_optional_cpp_nullopt_t.Invoke(agg_result);
				goto IL_0736;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			int2 = @int;
			num2 = (int)(cpp_enable_if_cpp_is_unsigned_v_unsigned_int128_int_type_cpp_countl_zero_unsigned_int128_unsigned_int128.Invoke(*(long*)(&int2), ((long*)(&int2))[1]) - 0L);
			@int = NumericHelper.ShiftLeft(@int, (Int128)(UInt128)(uint)num2);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = checked(internal_exp10_to_exp2_int.Invoke(num) + 128 + 16383) - num2;
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			long num5 = checked(num - -348);
			ptr = (byte*)internal_DETAILED_POWERS_OF_TEN.Pointer + (nint)num5 * sizeof(InlineArray2_Int64);
			llvm_lifetime_start_p0.Invoke(16L, &x);
			x = NumericHelper.Multiply((Int128)(UInt128)(ulong)internal_high64_unsigned_int128_const.Invoke(&@int), (Int128)(UInt128)((ulong*)ptr)[1]);
			llvm_lifetime_start_p0.Invoke(16L, &int3);
			int3 = NumericHelper.Multiply((Int128)(UInt128)(ulong)internal_high64_unsigned_int128_const.Invoke(&@int), (Int128)(UInt128)(*(ulong*)ptr));
			llvm_lifetime_start_p0.Invoke(16L, &y);
			y = NumericHelper.Multiply((Int128)(UInt128)(ulong)internal_low64_unsigned_int128_const.Invoke(&@int), (Int128)(UInt128)((ulong*)ptr)[1]);
			llvm_lifetime_start_p0.Invoke(16L, &x2);
			x2 = NumericHelper.Add(int3, y);
			x = NumericHelper.Add(y: InstructionHelper.Select(NumericHelper.IntCmpUlt(x2, int3), (Int128)0L, (Int128)0L), x: x);
			llvm_lifetime_start_p0.Invoke(16L, &int4);
			int4 = NumericHelper.Multiply((Int128)(UInt128)(ulong)internal_low64_unsigned_int128_const.Invoke(&@int), (Int128)(UInt128)(*(ulong*)ptr));
			llvm_lifetime_start_p0.Invoke(16L, &x3);
			x3 = NumericHelper.Add(int4, NumericHelper.ShiftLeft((Int128)(UInt128)(ulong)internal_low64_unsigned_int128_const.Invoke(&x2), 64L));
			llvm_lifetime_start_p0.Invoke(16L, &x4);
			x4 = NumericHelper.Add(NumericHelper.Add(x, (Int128)(UInt128)(ulong)internal_high64_unsigned_int128_const.Invoke(&x2)), InstructionHelper.Select(NumericHelper.IntCmpUlt(x3, int4), 1, 0));
			llvm_lifetime_start_p0.Invoke(16L, &int5);
			int5 = 4611686018427387903L;
			if (NumericHelper.IntCmpEq(NumericHelper.BitwiseAnd(x4, 4611686018427387903L), 4611686018427387903L) && NumericHelper.IntCmpUlt(NumericHelper.Add(x3, @int), @int))
			{
				cpp_optional_internal_ExpandedFloat_long_double_optional_cpp_nullopt_t.Invoke(agg_result);
				goto IL_0684;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = (int)NumericHelper.ShiftRightLogical(x4, 127L);
			llvm_lifetime_start_p0.Invoke(16L, &int6);
			int6 = NumericHelper.ShiftRightLogical(x4, (Int128)(UInt128)(uint)(num4 + 128 - 66));
			num3 -= 1 ^ num4;
			if (round == RoundDirection_b3pcwy.Nearest)
			{
				if (NumericHelper.IntCmpEq(x3, 0L) && NumericHelper.IntCmpEq(NumericHelper.BitwiseAnd(x4, 4611686018427387903L), 0L) && NumericHelper.IntCmpEq(NumericHelper.BitwiseAnd(int6, 3L), 1L))
				{
					cpp_optional_internal_ExpandedFloat_long_double_optional_cpp_nullopt_t.Invoke(agg_result);
					goto IL_0662;
				}
				int6 = NumericHelper.Add(y: NumericHelper.BitwiseAnd(int6, 1L), x: int6);
			}
			else if (round == RoundDirection_b3pcwy.Up && (NumericHelper.IntCmpUgt(x3, 0L) || NumericHelper.IntCmpUgt(NumericHelper.BitwiseAnd(x4, 4611686018427387903L), 0L)))
			{
				int6 = NumericHelper.Add(int6, 2L);
			}
			int6 = NumericHelper.ShiftRightLogical(int6, 1L);
		}
		if (NumericHelper.IntCmpUgt(NumericHelper.ShiftRightLogical(int6, 64L), 0L))
		{
			int6 = NumericHelper.ShiftRightLogical(int6, 1L);
			num3++;
		}
		if (num3 - 1 >= 32766)
		{
			cpp_optional_internal_ExpandedFloat_long_double_optional_cpp_nullopt_t.Invoke(agg_result);
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq2);
			unchecked
			{
				*(Int128*)(&internal_ExpandedFloat_9jummq2) = -6148914691236517206L;
				((int*)(&internal_ExpandedFloat_9jummq2))[4] = -1431655766;
				sbyte* ptr2 = (sbyte*)(&internal_ExpandedFloat_9jummq2) + 20;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				ptr2[4] = -86;
				ptr2[5] = -86;
				ptr2[6] = -86;
				ptr2[7] = -86;
				ptr2[8] = -86;
				ptr2[9] = -86;
				ptr2[10] = -86;
				ptr2[11] = -86;
				internal_ExpandedFloat_9jummq2.mantissa = int6;
				internal_ExpandedFloat_9jummq2.exponent = num3;
				cpp_optional_internal_ExpandedFloat_long_double_optional_internal_ExpandedFloat_long_double.Invoke(agg_result, &internal_ExpandedFloat_9jummq2);
				llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq2);
			}
		}
		goto IL_0662;
		IL_0684:
		llvm_lifetime_end_p0.Invoke(16L, &int5);
		llvm_lifetime_end_p0.Invoke(16L, &x4);
		llvm_lifetime_end_p0.Invoke(16L, &x3);
		llvm_lifetime_end_p0.Invoke(16L, &int4);
		llvm_lifetime_end_p0.Invoke(16L, &x2);
		llvm_lifetime_end_p0.Invoke(16L, &y);
		llvm_lifetime_end_p0.Invoke(16L, &int3);
		llvm_lifetime_end_p0.Invoke(16L, &x);
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		goto IL_0736;
		IL_0662:
		llvm_lifetime_end_p0.Invoke(16L, &int6);
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		goto IL_0684;
		IL_0736:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(16L, &@int);
	}
}
