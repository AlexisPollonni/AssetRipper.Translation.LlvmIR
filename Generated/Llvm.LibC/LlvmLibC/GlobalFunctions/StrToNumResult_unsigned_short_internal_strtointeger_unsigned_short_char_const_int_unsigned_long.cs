using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal12strtointegerItEENS_14StrToNumResultIT_EEPKcim")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned short> __llvm_libc_20_1_2_::internal::strtointeger<unsigned short>(char const*, int, unsigned long)")]
internal static partial class StrToNumResult_unsigned_short_internal_strtointeger_unsigned_short_char_const_int_unsigned_long
{
	public unsafe static Struct_fiz2nb Invoke(void* src, int @base, long src_len)
	{
		StrToNumResult_wwcts2 strToNumResult_wwcts = default(StrToNumResult_wwcts2);
		short num = 0;
		sbyte b = 0;
		long num2 = 0L;
		int num3 = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		short num4 = 0;
		short num5 = 0;
		short num6 = 0;
		int num7 = 0;
		long parsed_len = 0L;
		int num8 = @base;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = 0;
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
				StrToNumResult_unsigned_short_StrToNumResult_unsigned_short_long_int.Invoke(&strToNumResult_wwcts, 0, 0L, 0);
			}
			else if (num8 < 0 || num8 == 1 || num8 > 36)
			{
				StrToNumResult_unsigned_short_StrToNumResult_unsigned_short_long_int.Invoke(&strToNumResult_wwcts, 0, 0L, 22);
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
				b3 = 1;
				llvm_lifetime_start_p0.Invoke(1L, &b4);
				b4 = ((b2 == 43) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(2L, &num4);
				num4 = -1;
				llvm_lifetime_start_p0.Invoke(2L, &num5);
				num5 = InstructionHelper.Select((b4 & 1) == 1, cpp_internal_integer_impl_unsigned_short_unsigned_short_0_unsigned_short_65535_max.Invoke(), (short)(-1));
				llvm_lifetime_start_p0.Invoke(2L, &num6);
				num6 = (short)((ushort)num5 / num8);
				while ((ulong)num2 < (ulong)src_len && internal_isalnum_int_6.Invoke(((sbyte*)src)[num2]))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = internal_b36_char_to_int_int_8.Invoke(((sbyte*)src)[num2]);
					int num9;
					if (num7 >= num8)
					{
						num9 = 3;
					}
					else
					{
						b = 1;
						num2++;
						if ((ushort)num == (ushort)num5)
						{
							num3 = 34;
							num9 = 2;
						}
						else
						{
							if ((ushort)num > (ushort)num6)
							{
								num = num5;
								num3 = 34;
							}
							else
							{
								num = (short)checked(unchecked((ushort)num) * num8);
							}
							if ((ushort)num > checked(unchecked((ushort)num5) - num7))
							{
								num = num5;
								num3 = 34;
							}
							else
							{
								num = (short)checked(unchecked((ushort)num) + num7);
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
					if ((b4 & 1) == 1 || uint.MaxValue != 0)
					{
						StrToNumResult_unsigned_short_StrToNumResult_unsigned_short_long_int.Invoke(&strToNumResult_wwcts, cpp_internal_integer_impl_unsigned_short_unsigned_short_0_unsigned_short_65535_max.Invoke(), parsed_len, num3);
					}
					else
					{
						cpp_internal_integer_impl_unsigned_short_unsigned_short_0_unsigned_short_65535_min.Invoke();
						short value;
						long parsed_len2;
						int error;
						StrToNumResult_unsigned_short_StrToNumResult_unsigned_short_long_int.Invoke(&strToNumResult_wwcts, value, parsed_len2, error);
					}
				}
				else
				{
					StrToNumResult_unsigned_short_StrToNumResult_unsigned_short_long_int.Invoke(&strToNumResult_wwcts, (short)(((b4 & 1) != 1) ? checked(-unchecked((ushort)num)) : ((ushort)num)), parsed_len, num3);
				}
				llvm_lifetime_end_p0.Invoke(8L, &parsed_len);
				llvm_lifetime_end_p0.Invoke(2L, &num6);
				llvm_lifetime_end_p0.Invoke(2L, &num5);
				llvm_lifetime_end_p0.Invoke(2L, &num4);
				llvm_lifetime_end_p0.Invoke(1L, &b4);
				llvm_lifetime_end_p0.Invoke(1L, &b3);
				llvm_lifetime_end_p0.Invoke(1L, &b2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			return *(Struct_fiz2nb*)(&strToNumResult_wwcts);
		}
	}
}
