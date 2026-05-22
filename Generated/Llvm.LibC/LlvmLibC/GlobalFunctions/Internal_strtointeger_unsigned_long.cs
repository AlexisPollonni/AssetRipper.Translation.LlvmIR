using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strtointeger_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal12strtointegerImEENS_14StrToNumResultIT_EEPKcim")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned long> __llvm_libc_20_1_2_::internal::strtointeger<unsigned long>(char const*, int, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<unsigned long>")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_StrToNumResult_gbeb3a* Agg_result, [MangledName("src")][NativeType("char const*")] void* Src, [MangledName("base")][NativeType("int")] int Base, [MangledName("src_len")][NativeType("unsigned long")] long Src_len)
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
		int num8 = Base;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 0;
		unchecked
		{
			if (Src_len == 0L)
			{
				StrToNumResult_unsigned_long_Constructor.Invoke(Agg_result, 0L, 0L, 0);
			}
			else if (num8 < 0 || num8 == 1 || num8 > 36)
			{
				StrToNumResult_unsigned_long_Constructor.Invoke(Agg_result, 0L, 0L, 22);
			}
			else
			{
				num2 = (long)Internal_first_non_whitespace.Invoke(Src, Src_len) - (long)Src;
				Llvm_lifetime_start_p0.Invoke(1L, &b2);
				b2 = 43;
				if (((sbyte*)Src)[num2] == 43 || ((sbyte*)Src)[num2] == 45)
				{
					b2 = ((sbyte*)Src)[num2];
					num2++;
				}
				if (num8 == 0)
				{
					num8 = Internal_infer_base.Invoke((byte*)Src + num2, Src_len - num2);
				}
				if (num8 == 16 && Internal_is_hex_start.Invoke((byte*)Src + num2, Src_len - num2))
				{
					num2 += 2L;
				}
				Llvm_lifetime_start_p0.Invoke(1L, &b3);
				b3 = 1;
				Llvm_lifetime_start_p0.Invoke(1L, &b4);
				b4 = ((b2 == 43) ? ((sbyte)1) : ((sbyte)0));
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = -1L;
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = InstructionHelper.Select((b4 & 1) == 1, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke(), -1L);
				Llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = (long)((ulong)num5 / (ulong)num8);
				while ((ulong)num2 < (ulong)Src_len && Internal_isalnum_8q3d39.Invoke(((sbyte*)Src)[num2]))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = Internal_b36_char_to_int_x7564v.Invoke(((sbyte*)Src)[num2]);
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
					Llvm_lifetime_end_p0.Invoke(4L, &num7);
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
				Llvm_lifetime_start_p0.Invoke(8L, &parsed_len);
				parsed_len = (((b & 1) != 1) ? 0L : num2);
				if (num3 == 34)
				{
					if ((b4 & 1) == 1 || true)
					{
						StrToNumResult_unsigned_long_Constructor.Invoke(Agg_result, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke(), parsed_len, num3);
					}
					else
					{
						Integer_impl_unsigned_long_0ul_18446744073709551615ul_min.Invoke();
						long value;
						long parsed_len2;
						int error;
						StrToNumResult_unsigned_long_Constructor.Invoke(Agg_result, value, parsed_len2, error);
					}
				}
				else
				{
					StrToNumResult_unsigned_long_Constructor.Invoke(Agg_result, ((b4 & 1) != 1) ? (-num) : num, parsed_len, num3);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &parsed_len);
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				Llvm_lifetime_end_p0.Invoke(1L, &b4);
				Llvm_lifetime_end_p0.Invoke(1L, &b3);
				Llvm_lifetime_end_p0.Invoke(1L, &b2);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
