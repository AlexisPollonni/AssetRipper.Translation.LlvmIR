using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal12eisel_lemireIdEENS_3cpp8optionalINS0_13ExpandedFloatIT_EEEES6_NS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>> __llvm_libc_20_1_2_::internal::eisel_lemire<double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class cpp_optional_internal_ExpandedFloat_double_internal_eisel_lemire_double_internal_ExpandedFloat_double_internal_RoundDirection
{
	public unsafe static void Invoke([MangledName("agg.result")] cpp_optional_vqqfu4* agg_result, [MangledName("init_num.coerce0")] long init_num, [MangledName("init_num.coerce1")] int round, [MangledName("round")] int mantissa)
	{
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv2 = default(internal_ExpandedFloat_k68bhv);
		long num = 0L;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		void* ptr = null;
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		long num5 = 0L;
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		long num6 = 0L;
		long num7 = 0L;
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv3 = default(internal_ExpandedFloat_k68bhv);
		unchecked
		{
			*(long*)(&internal_ExpandedFloat_k68bhv2) = init_num;
			((int*)(&internal_ExpandedFloat_k68bhv2))[2] = round;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = internal_ExpandedFloat_k68bhv2.mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = internal_ExpandedFloat_k68bhv2.exponent;
			if (num2 < -348 || num2 > 347)
			{
				cpp_optional_internal_ExpandedFloat_double_optional_cpp_nullopt_t.Invoke(agg_result);
				goto IL_0568;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countl_zero_unsigned_long_unsigned_long.Invoke(num);
			num <<= (int)(uint)num3;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = checked(internal_exp10_to_exp2_int.Invoke(num2) + 64 + 1023) - num3;
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			long num8 = checked(num2 - -348);
			ptr = (byte*)internal_DETAILED_POWERS_OF_TEN.Pointer + (nint)num8 * sizeof(InlineArray2_Int64);
			llvm_lifetime_start_p0.Invoke(16L, &@int);
			@int = NumericHelper.Multiply((Int128)(UInt128)(ulong)num, (Int128)(UInt128)((ulong*)ptr)[1]);
			llvm_lifetime_start_p0.Invoke(16L, &int2);
			int2 = -6148914691236517206L;
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = 511L;
			if ((internal_high64_unsigned_int128_const.Invoke(&@int) & 0x1FFL) == 511L && (ulong)(internal_low64_unsigned_int128_const.Invoke(&@int) + num) < (ulong)num)
			{
				llvm_lifetime_start_p0.Invoke(16L, &int3);
				int3 = NumericHelper.Multiply((Int128)(UInt128)(ulong)num, (Int128)(UInt128)(*(ulong*)ptr));
				llvm_lifetime_start_p0.Invoke(16L, &int4);
				int4 = NumericHelper.Add(@int, (Int128)(UInt128)(ulong)internal_high64_unsigned_int128_const.Invoke(&int3));
				int num9;
				if ((internal_high64_unsigned_int128_const.Invoke(&int4) & 0x1FFL) == 511L && internal_low64_unsigned_int128_const.Invoke(&int4) + 1L == 0L && (ulong)(internal_low64_unsigned_int128_const.Invoke(&int3) + num) < (ulong)num)
				{
					cpp_optional_internal_ExpandedFloat_double_optional_cpp_nullopt_t.Invoke(agg_result);
					num9 = 1;
				}
				else
				{
					int2 = int4;
					num9 = 0;
				}
				llvm_lifetime_end_p0.Invoke(16L, &int4);
				llvm_lifetime_end_p0.Invoke(16L, &int3);
				switch (num9)
				{
				case 0:
					break;
				default:
					goto IL_0506;
				}
			}
			else
			{
				int2 = @int;
			}
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = internal_high64_unsigned_int128_const.Invoke(&int2) >>> 63;
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = internal_high64_unsigned_int128_const.Invoke(&int2) >>> (int)(num6 + 64L - 55L);
			num4 -= (int)(1L ^ num6);
			if (mantissa == 2)
			{
				if (internal_low64_unsigned_int128_const.Invoke(&int2) == 0L && (internal_high64_unsigned_int128_const.Invoke(&int2) & 0x1FFL) == 0L && (num7 & 3L) == 1L)
				{
					cpp_optional_internal_ExpandedFloat_double_optional_cpp_nullopt_t.Invoke(agg_result);
					goto IL_04e4;
				}
				num7 += num7 & 1L;
			}
			else if (mantissa == 0 && ((ulong)internal_low64_unsigned_int128_const.Invoke(&int2) > 0uL || (ulong)(internal_high64_unsigned_int128_const.Invoke(&int2) & 0x1FFL) > 0uL))
			{
				num7 += 2L;
			}
			num7 >>>= 1;
			if ((ulong)(num7 >>> 53) > 0uL)
			{
				num7 >>>= 1;
				num4 = checked(num4 + 1);
			}
			if ((uint)(num4 - 1) >= 2046u)
			{
				cpp_optional_internal_ExpandedFloat_double_optional_cpp_nullopt_t.Invoke(agg_result);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
				*(long*)(&internal_ExpandedFloat_k68bhv3) = -6148914691236517206L;
				((int*)(&internal_ExpandedFloat_k68bhv3))[2] = -1431655766;
				sbyte* ptr2 = (sbyte*)(&internal_ExpandedFloat_k68bhv3) + 12;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				internal_ExpandedFloat_k68bhv3.mantissa = num7;
				internal_ExpandedFloat_k68bhv3.exponent = num4;
				cpp_optional_internal_ExpandedFloat_double_optional_internal_ExpandedFloat_double.Invoke(agg_result, &internal_ExpandedFloat_k68bhv3);
				llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
			}
			goto IL_04e4;
		}
		IL_0506:
		llvm_lifetime_end_p0.Invoke(8L, &num5);
		llvm_lifetime_end_p0.Invoke(16L, &int2);
		llvm_lifetime_end_p0.Invoke(16L, &@int);
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_0568;
		IL_04e4:
		llvm_lifetime_end_p0.Invoke(8L, &num7);
		llvm_lifetime_end_p0.Invoke(8L, &num6);
		goto IL_0506;
		IL_0568:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
	}
}
