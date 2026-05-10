using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal19binary_exp_to_floatIdEENS0_18FloatConvertReturnIT_EENS0_13ExpandedFloatIS3_EEbNS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<double> __llvm_libc_20_1_2_::internal::binary_exp_to_float<double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>, bool, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class internal_FloatConvertReturn_double_internal_binary_exp_to_float_double_internal_ExpandedFloat_double_bool_internal_RoundDirection
{
	public unsafe static void Invoke([MangledName("agg.result")] internal_FloatConvertReturn_g92bm8* agg_result, [MangledName("init_num.coerce0")] long init_num, [MangledName("init_num.coerce1")] int truncated, [MangledName("truncated")] bool round, [MangledName("round")] int mantissa)
	{
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv2 = default(internal_ExpandedFloat_k68bhv);
		long num = 0L;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv3 = default(internal_ExpandedFloat_k68bhv);
		int num6 = 0;
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv4 = default(internal_ExpandedFloat_k68bhv);
		long num7 = 0L;
		long num8 = 0L;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv5 = default(internal_ExpandedFloat_k68bhv);
		unchecked
		{
			*(long*)(&internal_ExpandedFloat_k68bhv2) = init_num;
			((int*)(&internal_ExpandedFloat_k68bhv2))[2] = truncated;
			sbyte b4 = (round ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = internal_ExpandedFloat_k68bhv2.mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = internal_ExpandedFloat_k68bhv2.exponent;
			*(long*)agg_result = -6148914691236517206L;
			((int*)agg_result)[2] = -1431655766;
			sbyte* ptr = (sbyte*)agg_result + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((int*)agg_result)[4] = -1431655766;
			sbyte* ptr2 = (sbyte*)agg_result + 20;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			internal_FloatConvertReturn_double_FloatConvertReturn.Invoke(agg_result);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 2047;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countl_zero_unsigned_long_unsigned_long.Invoke(num);
			num <<= (int)(uint)num4;
			num2 -= num4;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = checked(num2 + 64 + 1023 - 1);
			if (num5 >= 2047)
			{
				llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
				internal_ExpandedFloat_k68bhv3.mantissa = 0L;
				internal_ExpandedFloat_k68bhv3.exponent = 2047;
				llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_k68bhv3, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
				agg_result->error = 34;
				goto IL_04eb;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = 11;
			if (num5 <= 0)
			{
				num6 += checked(1 - num5);
				num5 = 0;
				if ((uint)num6 > 64u)
				{
					llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv4);
					internal_ExpandedFloat_k68bhv4.mantissa = 0L;
					internal_ExpandedFloat_k68bhv4.exponent = 0;
					llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_k68bhv4, 16L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv4);
					agg_result->error = 34;
					goto IL_04d9;
				}
			}
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = 1L << (int)(uint)(num6 - 1);
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = num7 - 1L;
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((num & num7) != 0L) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = (sbyte)(byte)(((num & num8) == 0L) ? (((b4 & 1) == 1) ? 1 : 0) : (-1));
			if ((uint)num6 < 64u)
			{
				num >>>= (int)(uint)num6;
				num &= 0xFFFFFFFFFFFFFL;
			}
			else
			{
				num = 0L;
			}
			llvm_lifetime_start_p0.Invoke(1L, &b3);
			b3 = (((num & 1L) != 0L) ? ((sbyte)1) : ((sbyte)0));
			switch (mantissa)
			{
			case 2:
				if ((b & 1) == 1 && ((b3 & 1) == 1 || (b2 & 1) == 1))
				{
					num++;
				}
				break;
			case 0:
				if ((b & 1) == 1 || (b2 & 1) == 1)
				{
					num++;
				}
				break;
			default:
				if ((b & 1) == 1 && (b2 & 1) == 1)
				{
					num++;
				}
				break;
			}
			if ((ulong)num > 4503599627370495uL)
			{
				num5 = checked(num5 + 1);
				if (num5 == 2047)
				{
					agg_result->error = 34;
				}
			}
			if (num5 == 0)
			{
				agg_result->error = 34;
			}
			llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv5);
			internal_ExpandedFloat_k68bhv5.mantissa = num & 0xFFFFFFFFFFFFFL;
			internal_ExpandedFloat_k68bhv5.exponent = num5;
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_k68bhv5, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv5);
			llvm_lifetime_end_p0.Invoke(1L, &b3);
			llvm_lifetime_end_p0.Invoke(1L, &b2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			goto IL_04d9;
		}
		IL_04d9:
		llvm_lifetime_end_p0.Invoke(4L, &num6);
		goto IL_04eb;
		IL_04eb:
		llvm_lifetime_end_p0.Invoke(4L, &num5);
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
	}
}
