using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_convert_float_decimal_typed_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core27convert_float_decimal_typedIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiPNS0_6WriterERKNS0_13FormatSectionENS_6fputil6FPBitsIS4_EE")]
	[DemangledName("int __llvm_libc_20_1_2_::printf_core::convert_float_decimal_typed<double, 0>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&, __llvm_libc_20_1_2_::fputil::FPBits<double>)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("writer")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Printf_core_Writer* Writer, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection const&")] Printf_core_FormatSection* To_conv, [MangledName("float_bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<double>")] long Float_bits)
	{
		int result = 0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		int num = 0;
		int num2 = 0;
		sbyte init_sign_char = 0;
		int num3 = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		Printf_core_PaddingWriter printf_core_PaddingWriter = default(Printf_core_PaddingWriter);
		Printf_core_FloatWriter printf_core_FloatWriter = default(Printf_core_FloatWriter);
		FloatToString_rwjwy3 floatToString_rwjwy = default(FloatToString_rwjwy3);
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
		int round = 0;
		sbyte b3 = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num18 = 0;
		int num19 = 0;
		int num20 = 0;
		fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = Float_bits;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 52;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		unchecked
		{
			num2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_explicit_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(1L, &init_sign_char);
			init_sign_char = 0;
			if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)))
			{
				init_sign_char = 45;
			}
			else if (((byte)To_conv->Flags & 2) == 2)
			{
				init_sign_char = 43;
			}
			else if (((byte)To_conv->Flags & 4) == 4)
			{
				init_sign_char = 32;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = ((To_conv->Precision >= 0) ? To_conv->Precision : 6);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = ((num3 != 0 || ((byte)To_conv->Flags & 8) != 0) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = 0;
			Llvm_lifetime_start_p0.Invoke(16L, &printf_core_PaddingWriter);
			*(sbyte*)(&printf_core_PaddingWriter) = -86;
			((sbyte*)(&printf_core_PaddingWriter))[1] = -86;
			((sbyte*)(&printf_core_PaddingWriter))[2] = -86;
			sbyte* ptr = (sbyte*)(&printf_core_PaddingWriter) + 3;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			ptr[4] = -86;
			((long*)(&printf_core_PaddingWriter))[1] = -6148914691236517206L;
			PaddingWriter_Constructor.Invoke(&printf_core_PaddingWriter, To_conv, init_sign_char);
			Llvm_lifetime_start_p0.Invoke(96L, &printf_core_FloatWriter);
			Llvm_memset_p0_i64.Invoke(&printf_core_FloatWriter, -86, 96L, isVolatile: false);
			FloatWriter_Constructor.Invoke(&printf_core_FloatWriter, Writer, (b & 1) == 1, &printf_core_PaddingWriter);
			Llvm_lifetime_start_p0.Invoke(32L, &floatToString_rwjwy);
			*(long*)(&floatToString_rwjwy) = -6148914691236517206L;
			((int*)(&floatToString_rwjwy))[2] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&floatToString_rwjwy) + 12;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			*(Int128*)((byte*)(&floatToString_rwjwy) + 16) = -6148914691236517206L;
			FloatToString_double_0_Constructor.Invoke(&floatToString_rwjwy, FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = FloatToString_double_0_get_positive_blocks.Invoke(&floatToString_rwjwy);
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
		}
		num5 = unchecked((int)num4) - 1;
		int num21;
		unchecked
		{
			while (true)
			{
				if (num5 < 0)
				{
					num21 = 2;
					break;
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num6);
				num6 = FloatToString_double_0_get_positive_block.Invoke(&floatToString_rwjwy, num5);
				if ((b2 & 1) == 1)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = FloatWriter_write_middle_block.Invoke(&printf_core_FloatWriter, num6);
					if (num7 < 0)
					{
						result = num7;
						num21 = 1;
					}
					else
					{
						num21 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num7);
					switch (num21)
					{
					case 0:
						break;
					default:
						goto IL_0418;
					}
				}
				else if (num6 != 0)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num8);
					num8 = num5;
					FloatWriter_init.Invoke(&printf_core_FloatWriter, num8 * 9L + InstructionHelper.Select((b & 1) == 1, 1, 0) + (uint)num3, num8 * 9L);
					FloatWriter_write_first_block.Invoke(&printf_core_FloatWriter, num6, Exp_format: false);
					b2 = 1;
					Llvm_lifetime_end_p0.Invoke(8L, &num8);
				}
				num21 = 0;
				goto IL_0418;
				IL_0418:
				Llvm_lifetime_end_p0.Invoke(4L, &num6);
				switch (num21)
				{
				case 0:
					goto IL_0437;
				}
				break;
				IL_0437:
				num5 = checked(num5 + -1);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num5);
			if (num21 != 2)
			{
				goto IL_09ca;
			}
			if ((b2 & 1) != 1)
			{
				FloatWriter_init.Invoke(&printf_core_FloatWriter, (uint)(InstructionHelper.Select((b & 1) == 1, 1, 0) + num3), 0L);
				FloatWriter_write_first_block.Invoke(&printf_core_FloatWriter, 0, Exp_format: false);
			}
			if (num2 < 52)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num9);
				num9 = (int)((uint)num3 / 9u + 1);
				Llvm_lifetime_start_p0.Invoke(4L, &num10);
				num10 = 0;
				if ((ulong)(uint)num9 <= (ulong)FloatToString_double_0_zero_blocks_after_point.Invoke(&floatToString_rwjwy))
				{
					num10 = num9;
					Llvm_lifetime_start_p0.Invoke(4L, &num11);
					num11 = FloatWriter_write_zeroes.Invoke(&printf_core_FloatWriter, num3);
					if (num11 < 0)
					{
						result = num11;
						num21 = 1;
					}
					else
					{
						num21 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num11);
					switch (num21)
					{
					case 0:
						break;
					default:
						goto IL_08f1;
					}
				}
				else if ((ulong)(uint)num10 < (ulong)FloatToString_double_0_zero_blocks_after_point.Invoke(&floatToString_rwjwy))
				{
					num10 = (int)FloatToString_double_0_zero_blocks_after_point.Invoke(&floatToString_rwjwy);
					Llvm_lifetime_start_p0.Invoke(4L, &num12);
					num12 = FloatWriter_write_zeroes.Invoke(&printf_core_FloatWriter, 9 * num10);
					if (num12 < 0)
					{
						result = num12;
						num21 = 1;
					}
					else
					{
						num21 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num12);
					switch (num21)
					{
					case 0:
						break;
					default:
						goto IL_08f1;
					}
				}
				while (true)
				{
					if ((uint)num10 < (uint)num9)
					{
						if (FloatToString_double_0_is_lowest_block.Invoke(&floatToString_rwjwy, (uint)num10))
						{
							Llvm_lifetime_start_p0.Invoke(4L, &num_zeroes);
							num_zeroes = num3 - 9 * num10;
							Llvm_lifetime_start_p0.Invoke(4L, &num13);
							num13 = FloatWriter_write_zeroes.Invoke(&printf_core_FloatWriter, num_zeroes);
							if (num13 < 0)
							{
								result = num13;
								num21 = 1;
							}
							else
							{
								num21 = 0;
							}
							Llvm_lifetime_end_p0.Invoke(4L, &num13);
							switch (num21)
							{
							case 0:
								num21 = 5;
								break;
							}
							Llvm_lifetime_end_p0.Invoke(4L, &num_zeroes);
							if (num21 != 5)
							{
								break;
							}
						}
						else
						{
							Llvm_lifetime_start_p0.Invoke(4L, &num14);
							num14 = FloatToString_double_0_get_negative_block.Invoke(&floatToString_rwjwy, num10);
							if ((uint)num10 < (uint)(num9 - 1))
							{
								Llvm_lifetime_start_p0.Invoke(4L, &num15);
								num15 = FloatWriter_write_middle_block.Invoke(&printf_core_FloatWriter, num14);
								if (num15 < 0)
								{
									result = num15;
									num21 = 1;
								}
								else
								{
									num21 = 0;
								}
								Llvm_lifetime_end_p0.Invoke(4L, &num15);
								switch (num21)
								{
								case 0:
									num21 = 0;
									break;
								}
							}
							else
							{
								Llvm_lifetime_start_p0.Invoke(4L, &num16);
								num16 = (int)((uint)num3 - 9L * (long)(uint)num10);
								Llvm_lifetime_start_p0.Invoke(4L, &num17);
								num17 = 0;
								Llvm_lifetime_start_p0.Invoke(4L, &i);
								for (i = 0; (ulong)(uint)i < (ulong)(9L - (long)(uint)num16); i++)
								{
									num17 = (int)((uint)num14 % 10u);
									num14 = (int)((uint)num14 / 10u);
								}
								Llvm_lifetime_end_p0.Invoke(4L, &i);
								Llvm_lifetime_start_p0.Invoke(4L, &round);
								round = -1431655766;
								Llvm_lifetime_start_p0.Invoke(1L, &b3);
								b3 = (InstructionHelper.BooleanXor(Printf_core_zero_after_digits_unsigned_long.Invoke(checked(num2 - 52), num3, FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)), 52), right: true) ? ((sbyte)1) : ((sbyte)0));
								int last_digit = num17;
								bool truncated = (b3 & 1) == 1;
								anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
								round = (int)Printf_core_get_round_direction.Invoke(last_digit, truncated, anon_izyfb.Val);
								Llvm_lifetime_start_p0.Invoke(4L, &num18);
								num18 = FloatWriter_write_last_block.Invoke(&printf_core_FloatWriter, num14, (uint)num16, (RoundDirection_zvveyk)round, 0, 0);
								if (num18 < 0)
								{
									result = num18;
									num21 = 1;
								}
								else
								{
									num21 = 0;
								}
								Llvm_lifetime_end_p0.Invoke(4L, &num18);
								switch (num21)
								{
								case 0:
									num21 = 5;
									break;
								}
								Llvm_lifetime_end_p0.Invoke(1L, &b3);
								Llvm_lifetime_end_p0.Invoke(4L, &round);
								Llvm_lifetime_end_p0.Invoke(4L, &num17);
								Llvm_lifetime_end_p0.Invoke(4L, &num16);
							}
							Llvm_lifetime_end_p0.Invoke(4L, &num14);
							int num22 = num21;
							if (num22 == 0)
							{
								num10++;
								continue;
							}
							if (num22 != 5)
							{
								break;
							}
						}
					}
					num21 = 0;
					break;
				}
				goto IL_08f1;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num19);
			num19 = FloatWriter_write_zeroes.Invoke(&printf_core_FloatWriter, num3);
			if (num19 < 0)
			{
				result = num19;
				num21 = 1;
			}
			else
			{
				num21 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num19);
			switch (num21)
			{
			case 0:
				break;
			default:
				goto IL_09ca;
			}
			goto IL_0977;
		}
		IL_0977:
		Llvm_lifetime_start_p0.Invoke(4L, &num20);
		num20 = FloatWriter_right_pad.Invoke(&printf_core_FloatWriter);
		if (num20 < 0)
		{
			result = num20;
			num21 = 1;
		}
		else
		{
			num21 = 0;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num20);
		switch (num21)
		{
		case 0:
			result = 0;
			break;
		}
		goto IL_09ca;
		IL_09ca:
		Llvm_lifetime_end_p0.Invoke(8L, &num4);
		Llvm_lifetime_end_p0.Invoke(32L, &floatToString_rwjwy);
		Llvm_lifetime_end_p0.Invoke(96L, &printf_core_FloatWriter);
		Llvm_lifetime_end_p0.Invoke(16L, &printf_core_PaddingWriter);
		Llvm_lifetime_end_p0.Invoke(1L, &b2);
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(1L, &init_sign_char);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
		IL_08f1:
		Llvm_lifetime_end_p0.Invoke(4L, &num10);
		Llvm_lifetime_end_p0.Invoke(4L, &num9);
		switch (num21)
		{
		case 0:
			break;
		default:
			goto IL_09ca;
		}
		goto IL_0977;
	}
}
