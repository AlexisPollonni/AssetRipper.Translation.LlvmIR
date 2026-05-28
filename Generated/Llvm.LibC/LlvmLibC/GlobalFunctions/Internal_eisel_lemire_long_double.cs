using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_eisel_lemire_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal12eisel_lemireIeEENS_3cpp8optionalINS0_13ExpandedFloatIT_EEEES6_NS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>> __llvm_libc_20_1_2_::internal::eisel_lemire<long double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>")]
	public unsafe static void Invoke([MangledName("agg.result")] Cpp_optional_q5jaj8* Agg_result, [MangledName("init_num")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>")] void* Init_num, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
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
		Internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq = default(Internal_ExpandedFloat_9jummq);
		Llvm_lifetime_start_p0.Invoke(16L, &@int);
		unchecked
		{
			@int = ((Internal_ExpandedFloat_9jummq*)Init_num)->Mantissa;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = ((Internal_ExpandedFloat_9jummq*)Init_num)->Exponent;
			if (num < -348 || num > 347)
			{
				Optional_internal_ExpandedFloat_long_double_Constructor_bp9437.Invoke(Agg_result);
				goto IL_0736;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			int2 = @int;
			num2 = (int)(Cpp_countl_zero_unsigned_int128.Invoke(*(long*)(&int2), ((long*)(&int2))[1]) - 0L);
			@int = NumericHelper.ShiftLeft(@int, (Int128)(UInt128)(uint)num2);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = checked(Internal_exp10_to_exp2.Invoke(num) + 128 + 16383) - num2;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			long num5 = checked(num - -348);
			ptr = (byte*)Internal_DETAILED_POWERS_OF_TEN.Pointer + (nint)num5 * sizeof(InlineArray2_Int64);
			Llvm_lifetime_start_p0.Invoke(16L, &x);
			x = NumericHelper.Multiply((Int128)(UInt128)(ulong)Internal_high64.Invoke(&@int), (Int128)(UInt128)((ulong*)ptr)[1]);
			Llvm_lifetime_start_p0.Invoke(16L, &int3);
			int3 = NumericHelper.Multiply((Int128)(UInt128)(ulong)Internal_high64.Invoke(&@int), (Int128)(UInt128)(*(ulong*)ptr));
			Llvm_lifetime_start_p0.Invoke(16L, &y);
			y = NumericHelper.Multiply((Int128)(UInt128)(ulong)Internal_low64.Invoke(&@int), (Int128)(UInt128)((ulong*)ptr)[1]);
			Llvm_lifetime_start_p0.Invoke(16L, &x2);
			x2 = NumericHelper.Add(int3, y);
			x = NumericHelper.Add(y: InstructionHelper.Select(NumericHelper.IntCmpUlt(x2, int3), (Int128)0L, (Int128)0L), x: x);
			Llvm_lifetime_start_p0.Invoke(16L, &int4);
			int4 = NumericHelper.Multiply((Int128)(UInt128)(ulong)Internal_low64.Invoke(&@int), (Int128)(UInt128)(*(ulong*)ptr));
			Llvm_lifetime_start_p0.Invoke(16L, &x3);
			x3 = NumericHelper.Add(int4, NumericHelper.ShiftLeft((Int128)(UInt128)(ulong)Internal_low64.Invoke(&x2), 64L));
			Llvm_lifetime_start_p0.Invoke(16L, &x4);
			x4 = NumericHelper.Add(NumericHelper.Add(x, (Int128)(UInt128)(ulong)Internal_high64.Invoke(&x2)), InstructionHelper.Select(NumericHelper.IntCmpUlt(x3, int4), 1, 0));
			Llvm_lifetime_start_p0.Invoke(16L, &int5);
			int5 = 4611686018427387903L;
			if (NumericHelper.IntCmpEq(NumericHelper.BitwiseAnd(x4, 4611686018427387903L), 4611686018427387903L) && NumericHelper.IntCmpUlt(NumericHelper.Add(x3, @int), @int))
			{
				Optional_internal_ExpandedFloat_long_double_Constructor_bp9437.Invoke(Agg_result);
				goto IL_0684;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = (int)NumericHelper.ShiftRightLogical(x4, 127L);
			Llvm_lifetime_start_p0.Invoke(16L, &int6);
			int6 = NumericHelper.ShiftRightLogical(x4, (Int128)(UInt128)(uint)(num4 + 128 - 66));
			num3 -= 1 ^ num4;
			if (Round == RoundDirection_b3pcwy.Nearest)
			{
				if (NumericHelper.IntCmpEq(x3, 0L) && NumericHelper.IntCmpEq(NumericHelper.BitwiseAnd(x4, 4611686018427387903L), 0L) && NumericHelper.IntCmpEq(NumericHelper.BitwiseAnd(int6, 3L), 1L))
				{
					Optional_internal_ExpandedFloat_long_double_Constructor_bp9437.Invoke(Agg_result);
					goto IL_0662;
				}
				int6 = NumericHelper.Add(y: NumericHelper.BitwiseAnd(int6, 1L), x: int6);
			}
			else if (Round == RoundDirection_b3pcwy.Up && (NumericHelper.IntCmpUgt(x3, 0L) || NumericHelper.IntCmpUgt(NumericHelper.BitwiseAnd(x4, 4611686018427387903L), 0L)))
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
			Optional_internal_ExpandedFloat_long_double_Constructor_bp9437.Invoke(Agg_result);
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq);
			unchecked
			{
				*(Int128*)(&internal_ExpandedFloat_9jummq) = -6148914691236517206L;
				((int*)(&internal_ExpandedFloat_9jummq))[4] = -1431655766;
				sbyte* ptr2 = (sbyte*)(&internal_ExpandedFloat_9jummq) + 20;
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
				internal_ExpandedFloat_9jummq.Mantissa = int6;
				internal_ExpandedFloat_9jummq.Exponent = num3;
				Optional_internal_ExpandedFloat_long_double_Constructor_crcz7y.Invoke(Agg_result, &internal_ExpandedFloat_9jummq);
				Llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq);
			}
		}
		goto IL_0662;
		IL_0684:
		Llvm_lifetime_end_p0.Invoke(16L, &int5);
		Llvm_lifetime_end_p0.Invoke(16L, &x4);
		Llvm_lifetime_end_p0.Invoke(16L, &x3);
		Llvm_lifetime_end_p0.Invoke(16L, &int4);
		Llvm_lifetime_end_p0.Invoke(16L, &x2);
		Llvm_lifetime_end_p0.Invoke(16L, &y);
		Llvm_lifetime_end_p0.Invoke(16L, &int3);
		Llvm_lifetime_end_p0.Invoke(16L, &x);
		Llvm_lifetime_end_p0.Invoke(8L, &ptr);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		goto IL_0736;
		IL_0662:
		Llvm_lifetime_end_p0.Invoke(16L, &int6);
		Llvm_lifetime_end_p0.Invoke(4L, &num4);
		goto IL_0684;
		IL_0736:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(16L, &@int);
	}
}
