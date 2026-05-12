using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal12strtointegerIxEENS_14StrToNumResultIT_EEPKcim")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long long> __llvm_libc_20_1_2_::internal::strtointeger<long long>(char const*, int, unsigned long)")]
internal static partial class StrToNumResult_long_long_internal_strtointeger_long_long_char_const_int_unsigned_long
{
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_aztiru* agg_result, void* src, int @base, long src_len)
	{
		long num = 0L;
		sbyte b = 0;
		long num2 = 0L;
		int num3 = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		int num7 = 0;
		long parsed_len = 0L;
		int num8 = @base;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 0;
		unchecked
		{
			if (src_len == 0L)
			{
				StrToNumResult_long_long_StrToNumResult_long_long_long_int.Invoke(agg_result, 0L, 0L, 0);
			}
			else if (num8 < 0 || num8 == 1 || num8 > 36)
			{
				StrToNumResult_long_long_StrToNumResult_long_long_long_int.Invoke(agg_result, 0L, 0L, 22);
			}
			else
			{
				num2 = (long)internal_first_non_whitespace_char_const_unsigned_long.Invoke(src, src_len) - (long)src;
				llvm_lifetime_start_p0.Invoke(1L, &b2);
				b2 = 43;
				if (((sbyte*)src)[num2] == 43 || ((sbyte*)src)[num2] == 45)
				{
					b2 = ((sbyte*)src)[num2];
					num2++;
				}
				if (num8 == 0)
				{
					num8 = internal_infer_base_char_const_unsigned_long.Invoke((byte*)src + num2, src_len - num2);
				}
				if (num8 == 16 && internal_is_hex_start_char_const_unsigned_long.Invoke((byte*)src + num2, src_len - num2))
				{
					num2 += 2L;
				}
				llvm_lifetime_start_p0.Invoke(1L, &b3);
				b3 = 0;
				llvm_lifetime_start_p0.Invoke(1L, &b4);
				b4 = ((b2 == 43) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = long.MinValue;
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = InstructionHelper.Select((b4 & 1) == 1, cpp_internal_integer_impl_long_long_9223372036854775808ll_9223372036854775807ll_max.Invoke(), long.MinValue);
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = (long)((ulong)num5 / (ulong)num8);
				while ((ulong)num2 < (ulong)src_len && internal_isalnum_int_156.Invoke(((sbyte*)src)[num2]))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = internal_b36_char_to_int_int_157.Invoke(((sbyte*)src)[num2]);
					int num9;
					if (num7 >= num8)
					{
						num9 = 3;
					}
					else
					{
						b = 1;
						num2++;
						if (num == num5)
						{
							num3 = 34;
							num9 = 2;
						}
						else
						{
							if ((ulong)num > (ulong)num6)
							{
								num = num5;
								num3 = 34;
							}
							else
							{
								num *= num8;
							}
							if ((ulong)num > (ulong)(num5 - num7))
							{
								num = num5;
								num3 = 34;
							}
							else
							{
								num += num7;
							}
							num9 = 0;
						}
					}
					llvm_lifetime_end_p0.Invoke(4L, &num7);
					switch (num9)
					{
					case 0:
					case 2:
						continue;
					case 3:
						break;
					default:
						throw new NotImplementedException("Reached LLVM unreachable instruction.");
					}
					break;
				}
				llvm_lifetime_start_p0.Invoke(8L, &parsed_len);
				parsed_len = (((b & 1) != 1) ? 0L : num2);
				if (num3 == 34)
				{
					if ((b4 & 1) == 1)
					{
						StrToNumResult_long_long_StrToNumResult_long_long_long_int.Invoke(agg_result, cpp_internal_integer_impl_long_long_9223372036854775808ll_9223372036854775807ll_max.Invoke(), parsed_len, num3);
					}
					else
					{
						StrToNumResult_long_long_StrToNumResult_long_long_long_int.Invoke(agg_result, cpp_internal_integer_impl_long_long_9223372036854775808ll_9223372036854775807ll_min.Invoke(), parsed_len, num3);
					}
				}
				else
				{
					StrToNumResult_long_long_StrToNumResult_long_long_long_int.Invoke(agg_result, ((b4 & 1) != 1) ? (-num) : num, parsed_len, num3);
				}
				llvm_lifetime_end_p0.Invoke(8L, &parsed_len);
				llvm_lifetime_end_p0.Invoke(8L, &num6);
				llvm_lifetime_end_p0.Invoke(8L, &num5);
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(1L, &b4);
				llvm_lifetime_end_p0.Invoke(1L, &b3);
				llvm_lifetime_end_p0.Invoke(1L, &b2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
