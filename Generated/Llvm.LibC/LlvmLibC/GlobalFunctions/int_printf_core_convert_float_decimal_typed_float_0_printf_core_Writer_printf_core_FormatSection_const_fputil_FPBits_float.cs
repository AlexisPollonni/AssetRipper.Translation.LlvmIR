using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core27convert_float_decimal_typedIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiPNS0_6WriterERKNS0_13FormatSectionENS_6fputil6FPBitsIS4_EE")]
[DemangledName("int __llvm_libc_20_1_2_::printf_core::convert_float_decimal_typed<float, 0>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&, __llvm_libc_20_1_2_::fputil::FPBits<float>)")]
internal static partial class int_printf_core_convert_float_decimal_typed_float_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_float
{
	public unsafe static int Invoke(printf_core_Writer* writer, printf_core_FormatSection* to_conv, [MangledName("float_bits.coerce")] int float_bits)
	{
		int result = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		sbyte init_sign_char = 0;
		int num3 = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		printf_core_PaddingWriter printf_core_PaddingWriter2 = default(printf_core_PaddingWriter);
		printf_core_FloatWriter printf_core_FloatWriter2 = default(printf_core_FloatWriter);
		FloatToString_vnf553 floatToString_vnf = default(FloatToString_vnf553);
		long num4 = 0L;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		long num8 = 0L;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num_zeroes = 0;
		int num13 = 0;
		int num14 = 0;
		int num15 = 0;
		int num16 = 0;
		int num17 = 0;
		int i = 0;
		int num18 = 0;
		sbyte b3 = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num19 = 0;
		int num20 = 0;
		int num21 = 0;
		fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = float_bits;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 23;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		unchecked
		{
			num2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_explicit_exponent_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(1L, &init_sign_char);
			init_sign_char = 0;
			if (fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)))
			{
				init_sign_char = 45;
			}
			else if (((byte)to_conv->flags & 2) == 2)
			{
				init_sign_char = 43;
			}
			else if (((byte)to_conv->flags & 4) == 4)
			{
				init_sign_char = 32;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = ((to_conv->precision >= 0) ? to_conv->precision : 6);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (sbyte)(byte)((num3 == 0) ? ((((byte)to_conv->flags & 8) != 0) ? 1 : 0) : (-1));
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = 0;
			llvm_lifetime_start_p0.Invoke(16L, &printf_core_PaddingWriter2);
			*(sbyte*)(&printf_core_PaddingWriter2) = -86;
			((sbyte*)(&printf_core_PaddingWriter2))[1] = -86;
			((sbyte*)(&printf_core_PaddingWriter2))[2] = -86;
			sbyte* ptr = (sbyte*)(&printf_core_PaddingWriter2) + 3;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			ptr[4] = -86;
			((long*)(&printf_core_PaddingWriter2))[1] = -6148914691236517206L;
			printf_core_PaddingWriter_PaddingWriter_printf_core_FormatSection_const_char.Invoke(&printf_core_PaddingWriter2, to_conv, init_sign_char);
			llvm_lifetime_start_p0.Invoke(96L, &printf_core_FloatWriter2);
			llvm_memset_p0_i64.Invoke(&printf_core_FloatWriter2, -86, 96L, isVolatile: false);
			printf_core_FloatWriter_FloatWriter_printf_core_Writer_bool_printf_core_PaddingWriter_const.Invoke(&printf_core_FloatWriter2, writer, (b & 1) == 1, &printf_core_PaddingWriter2);
			llvm_lifetime_start_p0.Invoke(32L, &floatToString_vnf);
			*(int*)(&floatToString_vnf) = -1431655766;
			((int*)(&floatToString_vnf))[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&floatToString_vnf) + 8;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			ptr2[4] = -86;
			ptr2[5] = -86;
			ptr2[6] = -86;
			ptr2[7] = -86;
			*(Int128*)((byte*)(&floatToString_vnf) + 16) = -6148914691236517206L;
			FloatToString_float_0_FloatToString_float.Invoke(&floatToString_vnf, fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = FloatToString_float_0_get_positive_blocks.Invoke(&floatToString_vnf);
			llvm_lifetime_start_p0.Invoke(4L, &num5);
		}
		num5 = unchecked((int)num4) - 1;
		int num22;
		unchecked
		{
			while (true)
			{
				if (num5 < 0)
				{
					num22 = 2;
					break;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num6);
				num6 = FloatToString_float_0_get_positive_block_int.Invoke(&floatToString_vnf, num5);
				if ((b2 & 1) == 1)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = printf_core_FloatWriter_write_middle_block_unsigned_int.Invoke(&printf_core_FloatWriter2, num6);
					if (num7 < 0)
					{
						result = num7;
						num22 = 1;
					}
					else
					{
						num22 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num7);
					switch (num22)
					{
					case 0:
						break;
					default:
						goto IL_0433;
					}
				}
				else if (num6 != 0)
				{
					llvm_lifetime_start_p0.Invoke(8L, &num8);
					num8 = num5;
					printf_core_FloatWriter_init_unsigned_long_unsigned_long.Invoke(&printf_core_FloatWriter2, num8 * 9L + InstructionHelper.Select((b & 1) == 1, 1, 0) + (uint)num3, num8 * 9L);
					printf_core_FloatWriter_write_first_block_unsigned_int_bool.Invoke(&printf_core_FloatWriter2, num6, exp_format: false);
					b2 = 1;
					llvm_lifetime_end_p0.Invoke(8L, &num8);
				}
				num22 = 0;
				goto IL_0433;
				IL_0433:
				llvm_lifetime_end_p0.Invoke(4L, &num6);
				switch (num22)
				{
				case 0:
					goto IL_0452;
				}
				break;
				IL_0452:
				num5 = checked(num5 + -1);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			if (num22 != 2)
			{
				goto IL_09e1;
			}
			if ((b2 & 1) != 1)
			{
				printf_core_FloatWriter_init_unsigned_long_unsigned_long.Invoke(&printf_core_FloatWriter2, (uint)(InstructionHelper.Select((b & 1) == 1, 1, 0) + num3), 0L);
				printf_core_FloatWriter_write_first_block_unsigned_int_bool.Invoke(&printf_core_FloatWriter2, 0, exp_format: false);
			}
			if (num2 < 23)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num9);
				num9 = (int)((uint)num3 / 9u + 1);
				llvm_lifetime_start_p0.Invoke(4L, &num10);
				num10 = 0;
				if ((ulong)(uint)num9 <= (ulong)FloatToString_float_0_zero_blocks_after_point.Invoke(&floatToString_vnf))
				{
					num10 = num9;
					llvm_lifetime_start_p0.Invoke(4L, &num11);
					num11 = printf_core_FloatWriter_write_zeroes_unsigned_int.Invoke(&printf_core_FloatWriter2, num3);
					if (num11 < 0)
					{
						result = num11;
						num22 = 1;
					}
					else
					{
						num22 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num11);
					switch (num22)
					{
					case 0:
						break;
					default:
						goto IL_0908;
					}
				}
				else if ((ulong)(uint)num10 < (ulong)FloatToString_float_0_zero_blocks_after_point.Invoke(&floatToString_vnf))
				{
					num10 = (int)FloatToString_float_0_zero_blocks_after_point.Invoke(&floatToString_vnf);
					llvm_lifetime_start_p0.Invoke(4L, &num12);
					num12 = printf_core_FloatWriter_write_zeroes_unsigned_int.Invoke(&printf_core_FloatWriter2, 9 * num10);
					if (num12 < 0)
					{
						result = num12;
						num22 = 1;
					}
					else
					{
						num22 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num12);
					switch (num22)
					{
					case 0:
						break;
					default:
						goto IL_0908;
					}
				}
				while (true)
				{
					if ((uint)num10 < (uint)num9)
					{
						if (FloatToString_float_0_is_lowest_block_unsigned_long.Invoke(&floatToString_vnf, (uint)num10))
						{
							llvm_lifetime_start_p0.Invoke(4L, &num_zeroes);
							num_zeroes = num3 - 9 * num10;
							llvm_lifetime_start_p0.Invoke(4L, &num13);
							num13 = printf_core_FloatWriter_write_zeroes_unsigned_int.Invoke(&printf_core_FloatWriter2, num_zeroes);
							if (num13 < 0)
							{
								result = num13;
								num22 = 1;
							}
							else
							{
								num22 = 0;
							}
							llvm_lifetime_end_p0.Invoke(4L, &num13);
							switch (num22)
							{
							case 0:
								num22 = 5;
								break;
							}
							llvm_lifetime_end_p0.Invoke(4L, &num_zeroes);
							if (num22 != 5)
							{
								break;
							}
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(4L, &num14);
							num14 = FloatToString_float_0_get_negative_block_int.Invoke(&floatToString_vnf, num10);
							if ((uint)num10 < (uint)(num9 - 1))
							{
								llvm_lifetime_start_p0.Invoke(4L, &num15);
								num15 = printf_core_FloatWriter_write_middle_block_unsigned_int.Invoke(&printf_core_FloatWriter2, num14);
								if (num15 < 0)
								{
									result = num15;
									num22 = 1;
								}
								else
								{
									num22 = 0;
								}
								llvm_lifetime_end_p0.Invoke(4L, &num15);
								switch (num22)
								{
								case 0:
									num22 = 0;
									break;
								}
							}
							else
							{
								llvm_lifetime_start_p0.Invoke(4L, &num16);
								num16 = (int)((uint)num3 - 9L * (long)(uint)num10);
								llvm_lifetime_start_p0.Invoke(4L, &num17);
								num17 = 0;
								llvm_lifetime_start_p0.Invoke(4L, &i);
								for (i = 0; (ulong)(uint)i < (ulong)(9L - (long)(uint)num16); i++)
								{
									num17 = (int)((uint)num14 % 10u);
									num14 = (int)((uint)num14 / 10u);
								}
								llvm_lifetime_end_p0.Invoke(4L, &i);
								llvm_lifetime_start_p0.Invoke(4L, &num18);
								num18 = -1431655766;
								llvm_lifetime_start_p0.Invoke(1L, &b3);
								b3 = (sbyte)(byte)((cpp_enable_if_cpp_is_integral_v_unsigned_int_is_big_int_v_unsigned_int_bool_type_printf_core_zero_after_digits_unsigned_int_int_int_unsigned_int_int.Invoke(checked(num2 - 23), num3, fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa_const.Invoke(&fputil_FPBits_5nkvcs2), 23) ? 1 : 0) ^ -1);
								int last_digit = num17;
								bool truncated = (b3 & 1) == 1;
								anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
								num18 = (int)printf_core_get_round_direction_int_bool_Sign.Invoke(last_digit, truncated, anon_izyfb8.val);
								llvm_lifetime_start_p0.Invoke(4L, &num19);
								num19 = printf_core_FloatWriter_write_last_block_unsigned_int_unsigned_long_printf_core_RoundDirection_int_char.Invoke(&printf_core_FloatWriter2, num14, (uint)num16, (RoundDirection_zvveyk)num18, 0, 0);
								if (num19 < 0)
								{
									result = num19;
									num22 = 1;
								}
								else
								{
									num22 = 0;
								}
								llvm_lifetime_end_p0.Invoke(4L, &num19);
								switch (num22)
								{
								case 0:
									num22 = 5;
									break;
								}
								llvm_lifetime_end_p0.Invoke(1L, &b3);
								llvm_lifetime_end_p0.Invoke(4L, &num18);
								llvm_lifetime_end_p0.Invoke(4L, &num17);
								llvm_lifetime_end_p0.Invoke(4L, &num16);
							}
							llvm_lifetime_end_p0.Invoke(4L, &num14);
							int num23 = num22;
							if (num23 == 0)
							{
								num10++;
								continue;
							}
							if (num23 != 5)
							{
								break;
							}
						}
					}
					num22 = 0;
					break;
				}
				goto IL_0908;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num20);
			num20 = printf_core_FloatWriter_write_zeroes_unsigned_int.Invoke(&printf_core_FloatWriter2, num3);
			if (num20 < 0)
			{
				result = num20;
				num22 = 1;
			}
			else
			{
				num22 = 0;
			}
			llvm_lifetime_end_p0.Invoke(4L, &num20);
			switch (num22)
			{
			case 0:
				break;
			default:
				goto IL_09e1;
			}
			goto IL_098e;
		}
		IL_098e:
		llvm_lifetime_start_p0.Invoke(4L, &num21);
		num21 = printf_core_FloatWriter_right_pad.Invoke(&printf_core_FloatWriter2);
		if (num21 < 0)
		{
			result = num21;
			num22 = 1;
		}
		else
		{
			num22 = 0;
		}
		llvm_lifetime_end_p0.Invoke(4L, &num21);
		switch (num22)
		{
		case 0:
			result = 0;
			break;
		}
		goto IL_09e1;
		IL_09e1:
		llvm_lifetime_end_p0.Invoke(8L, &num4);
		llvm_lifetime_end_p0.Invoke(32L, &floatToString_vnf);
		llvm_lifetime_end_p0.Invoke(96L, &printf_core_FloatWriter2);
		llvm_lifetime_end_p0.Invoke(16L, &printf_core_PaddingWriter2);
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(1L, &init_sign_char);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
		IL_0908:
		llvm_lifetime_end_p0.Invoke(4L, &num10);
		llvm_lifetime_end_p0.Invoke(4L, &num9);
		switch (num22)
		{
		case 0:
			break;
		default:
			goto IL_09e1;
		}
		goto IL_098e;
	}
}
