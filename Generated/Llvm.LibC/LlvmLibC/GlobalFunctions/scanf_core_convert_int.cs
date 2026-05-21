using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class scanf_core_convert_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core11convert_intEPNS0_6ReaderERKNS0_13FormatSectionE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert_int(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::scanf_core::Reader*")] scanf_core_Reader* reader, [NativeType("__llvm_libc_20_1_2_::scanf_core::FormatSection const&")] scanf_core_FormatSection* to_conv)
	{
		long num = 0L;
		long num2 = 0L;
		sbyte b = 0;
		sbyte b2 = 0;
		int num3 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		sbyte b5 = 0;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		sbyte b6 = 0;
		long num9 = 0L;
		long num10 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke();
		if (to_conv->max_width > 0)
		{
			num = to_conv->max_width;
		}
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
		llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 0;
		if (to_conv->conv_name == 105)
		{
			num3 = 0;
			b2 = 1;
		}
		else if (to_conv->conv_name == 111)
		{
			num3 = 8;
		}
		else if (internal_tolower_vqndr4.Invoke(to_conv->conv_name) == 120 || to_conv->conv_name == 112)
		{
			num3 = 16;
		}
		else if (to_conv->conv_name == 100)
		{
			num3 = 10;
			b2 = 1;
		}
		else
		{
			num3 = 10;
		}
		llvm_lifetime_start_p0.Invoke(1L, &b3);
		b3 = Reader_getc.Invoke(reader);
		llvm_lifetime_start_p0.Invoke(1L, &b4);
		b4 = 43;
		int result;
		unchecked
		{
			if (b3 == 43 || b3 == 45)
			{
				b4 = b3;
				if ((ulong)num <= 1uL)
				{
					scanf_core_write_int_with_length.Invoke(0L, to_conv);
					result = -3;
					goto IL_05ac;
				}
				num += -1L;
				b3 = Reader_getc.Invoke(reader);
			}
			llvm_lifetime_start_p0.Invoke(1L, &b5);
			b5 = ((b4 == 45) ? ((sbyte)1) : ((sbyte)0));
			if (num3 == 0 || num3 == 16)
			{
				if (b3 == 48)
				{
					b = 1;
					if ((ulong)num <= 1uL)
					{
						scanf_core_write_int_with_length.Invoke(0L, to_conv);
						result = 0;
						goto IL_059a;
					}
					num += -1L;
					b3 = Reader_getc.Invoke(reader);
					if (internal_tolower_vqndr4.Invoke(b3) == 120)
					{
						b = 0;
						num3 = 16;
						if ((ulong)num <= 1uL)
						{
							result = -3;
							goto IL_059a;
						}
						num += -1L;
						b3 = Reader_getc.Invoke(reader);
					}
					else if (num3 == 0)
					{
						num3 = 8;
					}
				}
				else if (num3 == 0)
				{
					if (!internal_isdigit_j33sgs.Invoke(b3))
					{
						Reader_ungetc.Invoke(reader, b3);
						scanf_core_write_int_with_length.Invoke(0L, to_conv);
						result = -3;
						goto IL_059a;
					}
					num3 = 10;
				}
			}
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = -1L;
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = long.MaxValue;
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = long.MinValue;
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = (((b2 & 1) != 1) ? (-1L) : InstructionHelper.Select((b5 & 1) == 1, long.MinValue, long.MaxValue));
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = (long)((ulong)num7 / (ulong)num3);
			if (internal_isalnum_egn7bk.Invoke(b3) && internal_b36_char_to_int_spp3hr.Invoke(b3) < num3)
			{
				b = 1;
			}
			llvm_lifetime_start_p0.Invoke(1L, &b6);
			b6 = 0;
			llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = 0L;
			while ((ulong)num9 < (ulong)num && internal_isalnum_egn7bk.Invoke(b3) && internal_b36_char_to_int_spp3hr.Invoke(b3) < num3)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = internal_b36_char_to_int_spp3hr.Invoke(b3);
				int num11;
				if (num2 == num7)
				{
					b6 = 1;
					num11 = 4;
				}
				else
				{
					if ((ulong)num2 > (ulong)num8)
					{
						num2 = num7;
						b6 = 1;
					}
					else
					{
						num2 *= num3;
					}
					if ((ulong)num2 > (ulong)(num7 - num10))
					{
						num2 = num7;
						b6 = 1;
					}
					else
					{
						num2 += num10;
					}
					num11 = 0;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num10);
				int num12 = num11;
				if (num12 == 0 || num12 == 4)
				{
					num9++;
					b3 = Reader_getc.Invoke(reader);
					continue;
				}
				throw new NotImplementedException("Reached LLVM unreachable instruction.");
			}
			Reader_ungetc.Invoke(reader, b3);
			if ((b & 1) != 1)
			{
				result = -3;
			}
			else
			{
				if ((b6 & 1) == 1)
				{
					scanf_core_write_int_with_length.Invoke(num7, to_conv);
				}
				else
				{
					if ((b5 & 1) == 1)
					{
						num2 = -num2;
					}
					scanf_core_write_int_with_length.Invoke(num2, to_conv);
				}
				result = 0;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num9);
			llvm_lifetime_end_p0.Invoke(1L, &b6);
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			goto IL_059a;
		}
		IL_05ac:
		llvm_lifetime_end_p0.Invoke(1L, &b4);
		llvm_lifetime_end_p0.Invoke(1L, &b3);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
		IL_059a:
		llvm_lifetime_end_p0.Invoke(1L, &b5);
		goto IL_05ac;
	}
}
