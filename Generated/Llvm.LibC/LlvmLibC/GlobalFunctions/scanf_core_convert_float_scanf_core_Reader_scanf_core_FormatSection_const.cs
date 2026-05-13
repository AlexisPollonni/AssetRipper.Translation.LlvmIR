using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core13convert_floatEPNS0_6ReaderERKNS0_13FormatSectionE")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert_float(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
internal static partial class scanf_core_convert_float_scanf_core_Reader_scanf_core_FormatSection_const
{
	public unsafe static int Invoke(scanf_core_Reader* reader, scanf_core_FormatSection* to_conv)
	{
		CharVector charVector = default(CharVector);
		sbyte b = 0;
		long num = 0L;
		sbyte b2 = 0;
		long num2 = 0L;
		long num3 = 0L;
		int num4 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		llvm_lifetime_start_p0.Invoke(88L, &charVector);
		llvm_memset_p0_i64.Invoke(&charVector, -86, 88L, isVolatile: false);
		llvm_memset_p0_i64.Invoke(&charVector, 0, 88L, isVolatile: false);
		CharVector_CharVector_yauiu7.Invoke(&charVector);
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke();
		if (to_conv->max_width > 0)
		{
			num = to_conv->max_width;
		}
		llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = scanf_core_Reader_getc.Invoke(reader);
		if (b2 != 43 && b2 != 45)
		{
			goto IL_0111;
		}
		int result;
		if (!CharVector_append_char.Invoke(&charVector, b2))
		{
			result = -4;
		}
		else
		{
			if (CharVector_length.Invoke(&charVector) != num)
			{
				b2 = scanf_core_Reader_getc.Invoke(reader);
				goto IL_0111;
			}
			result = -3;
		}
		goto IL_05cd;
		IL_05cd:
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		CharVector_CharVector_spr6gr.Invoke(&charVector);
		llvm_lifetime_end_p0.Invoke(88L, &charVector);
		return result;
		IL_05bb:
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		goto IL_05cd;
		IL_0111:
		unchecked
		{
			if (internal_tolower_int_118.Invoke(b2) == *(sbyte*)scanf_core_convert_float_scanf_core_Reader_scanf_core_FormatSection_const_inf_string.Pointer)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = 0L;
				while (true)
				{
					if ((ulong)num2 < 8uL && (ulong)CharVector_length.Invoke(&charVector) < (ulong)num)
					{
						int num5 = internal_tolower_int_118.Invoke(b2);
						long num6 = num2;
						if (num5 == ((sbyte*)scanf_core_convert_float_scanf_core_Reader_scanf_core_FormatSection_const_inf_string.Pointer)[num6])
						{
							if (!CharVector_append_char.Invoke(&charVector, b2))
							{
								result = -4;
								break;
							}
							b2 = scanf_core_Reader_getc.Invoke(reader);
							num2++;
							continue;
						}
					}
					if (num2 == 3L || num2 == 8L)
					{
						scanf_core_write_float_with_length_char_scanf_core_FormatSection_const.Invoke(CharVector_c_str.Invoke(&charVector), to_conv);
						result = 0;
					}
					else
					{
						result = -3;
					}
					break;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			else
			{
				if (internal_tolower_int_118.Invoke(b2) != *(sbyte*)scanf_core_convert_float_scanf_core_Reader_scanf_core_FormatSection_const_nan_string.Pointer)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = 10;
					if (b2 != 48)
					{
						goto IL_03a4;
					}
					b = 1;
					if (!CharVector_append_char.Invoke(&charVector, b2))
					{
						result = -4;
					}
					else if (CharVector_length.Invoke(&charVector) == num)
					{
						scanf_core_write_float_with_length_char_scanf_core_FormatSection_const.Invoke(CharVector_c_str.Invoke(&charVector), to_conv);
						result = 0;
					}
					else
					{
						b2 = scanf_core_Reader_getc.Invoke(reader);
						if (internal_tolower_int_118.Invoke(b2) != 120)
						{
							goto IL_03a4;
						}
						num4 = 16;
						if (!CharVector_append_char.Invoke(&charVector, b2))
						{
							result = -4;
						}
						else
						{
							if (CharVector_length.Invoke(&charVector) != num)
							{
								b2 = scanf_core_Reader_getc.Invoke(reader);
								goto IL_03a4;
							}
							scanf_core_write_float_with_length_char_scanf_core_FormatSection_const.Invoke(CharVector_c_str.Invoke(&charVector), to_conv);
							result = 0;
						}
					}
					goto IL_05bb;
				}
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = 0L;
				while (true)
				{
					if ((ulong)num3 < 3uL && (ulong)CharVector_length.Invoke(&charVector) < (ulong)num)
					{
						int num7 = internal_tolower_int_118.Invoke(b2);
						long num8 = num3;
						if (num7 == ((sbyte*)scanf_core_convert_float_scanf_core_Reader_scanf_core_FormatSection_const_nan_string.Pointer)[num8])
						{
							if (!CharVector_append_char.Invoke(&charVector, b2))
							{
								result = -4;
								break;
							}
							b2 = scanf_core_Reader_getc.Invoke(reader);
							num3++;
							continue;
						}
					}
					if (num3 == 3L)
					{
						scanf_core_write_float_with_length_char_scanf_core_FormatSection_const.Invoke(CharVector_c_str.Invoke(&charVector), to_conv);
						result = 0;
					}
					else
					{
						result = -3;
					}
					break;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num3);
			}
			goto IL_05cd;
		}
		IL_03a4:
		llvm_lifetime_start_p0.Invoke(1L, &b3);
		b3 = InstructionHelper.Select(num4 == 10, (sbyte)101, (sbyte)112);
		llvm_lifetime_start_p0.Invoke(1L, &b4);
		b4 = 0;
		unchecked
		{
			while (true)
			{
				if ((ulong)CharVector_length.Invoke(&charVector) < (ulong)num)
				{
					if (internal_isalnum_int_119.Invoke(b2) && internal_b36_char_to_int_int_120.Invoke(b2) < num4)
					{
						b = 1;
						if (!CharVector_append_char.Invoke(&charVector, b2))
						{
							result = -4;
							break;
						}
						b2 = scanf_core_Reader_getc.Invoke(reader);
						continue;
					}
					if (b2 == 46 && (b4 & 1) != 1)
					{
						b4 = 1;
						if (!CharVector_append_char.Invoke(&charVector, b2))
						{
							result = -4;
							break;
						}
						b2 = scanf_core_Reader_getc.Invoke(reader);
						continue;
					}
				}
				if (internal_tolower_int_118.Invoke(b2) == b3)
				{
					if (!CharVector_append_char.Invoke(&charVector, b2))
					{
						result = -4;
						break;
					}
					if (CharVector_length.Invoke(&charVector) == num)
					{
						result = -3;
						break;
					}
					b2 = scanf_core_Reader_getc.Invoke(reader);
					if (b2 == 43 || b2 == 45)
					{
						if (!CharVector_append_char.Invoke(&charVector, b2))
						{
							result = -4;
							break;
						}
						if (CharVector_length.Invoke(&charVector) == num)
						{
							result = -3;
							break;
						}
						b2 = scanf_core_Reader_getc.Invoke(reader);
					}
					if (!internal_isdigit_int_121.Invoke(b2))
					{
						result = -3;
						break;
					}
					while (internal_isdigit_int_121.Invoke(b2) && (ulong)CharVector_length.Invoke(&charVector) < (ulong)num)
					{
						if (!CharVector_append_char.Invoke(&charVector, b2))
						{
							goto IL_055d;
						}
						b2 = scanf_core_Reader_getc.Invoke(reader);
					}
				}
				scanf_core_Reader_ungetc_char.Invoke(reader, b2);
				if ((b & 1) != 1)
				{
					result = -3;
					break;
				}
				scanf_core_write_float_with_length_char_scanf_core_FormatSection_const.Invoke(CharVector_c_str.Invoke(&charVector), to_conv);
				result = 0;
				break;
				IL_055d:
				result = -4;
				break;
			}
			llvm_lifetime_end_p0.Invoke(1L, &b4);
			llvm_lifetime_end_p0.Invoke(1L, &b3);
			goto IL_05bb;
		}
	}
}
