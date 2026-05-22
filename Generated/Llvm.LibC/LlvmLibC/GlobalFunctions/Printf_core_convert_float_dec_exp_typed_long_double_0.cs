using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_convert_float_dec_exp_typed_long_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core27convert_float_dec_exp_typedIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiPNS0_6WriterERKNS0_13FormatSectionENS_6fputil6FPBitsIS4_EE")]
	[DemangledName("int __llvm_libc_20_1_2_::printf_core::convert_float_dec_exp_typed<long double, 0>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&, __llvm_libc_20_1_2_::fputil::FPBits<long double>)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("writer")] Llvm_libc_20_1_2_printf_core_Writer* Writer, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Llvm_libc_20_1_2_printf_core_FormatSection* To_conv, [MangledName("float_bits.coerce0")][NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection const&")] long Float_bits, [MangledName("float_bits.coerce1")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<long double>")] long FRACTION_LEN)
	{
		int result = 0;
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		int num = 0;
		int num2 = 0;
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		sbyte init_sign_char = 0;
		int num3 = 0;
		sbyte b = 0;
		Llvm_libc_20_1_2_printf_core_PaddingWriter llvm_libc_20_1_2_printf_core_PaddingWriter = default(Llvm_libc_20_1_2_printf_core_PaddingWriter);
		Llvm_libc_20_1_2_printf_core_FloatWriter llvm_libc_20_1_2_printf_core_FloatWriter = default(Llvm_libc_20_1_2_printf_core_FloatWriter);
		Llvm_libc_20_1_2_FloatToString_8m29tk llvm_libc_20_1_2_FloatToString_8m29tk = default(Llvm_libc_20_1_2_FloatToString_8m29tk);
		long num4 = 0L;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		long num8 = 0L;
		Llvm_libc_20_1_2_IntegerToString_uuwdyc llvm_libc_20_1_2_IntegerToString_uuwdyc = default(Llvm_libc_20_1_2_IntegerToString_uuwdyc);
		int num9 = 0;
		long num10 = 0L;
		Llvm_libc_20_1_2_IntegerToString_uuwdyc llvm_libc_20_1_2_IntegerToString_uuwdyc2 = default(Llvm_libc_20_1_2_IntegerToString_uuwdyc);
		int num11 = 0;
		long num12 = 0L;
		Llvm_libc_20_1_2_IntegerToString_uuwdyc llvm_libc_20_1_2_IntegerToString_uuwdyc3 = default(Llvm_libc_20_1_2_IntegerToString_uuwdyc);
		sbyte b2 = 0;
		long num13 = 0L;
		int num14 = 0;
		int i = 0;
		int num15 = 0;
		int round = 0;
		int j = 0;
		int num16 = 0;
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num17 = 0;
		int num18 = 0;
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = Float_bits;
			((long*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))[1] = FRACTION_LEN;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 63;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			Llvm_lifetime_start_p0.Invoke(16L, &x);
			Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			Int128* num19 = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num19 = struct_fiz2nb2.field_0;
			byte* num20 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num20 = struct_fiz2nb3.field_1;
			x = @int;
			Llvm_lifetime_start_p0.Invoke(1L, &init_sign_char);
			init_sign_char = 0;
			if (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
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
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_printf_core_PaddingWriter);
			*(sbyte*)(&llvm_libc_20_1_2_printf_core_PaddingWriter) = -86;
			((sbyte*)(&llvm_libc_20_1_2_printf_core_PaddingWriter))[1] = -86;
			((sbyte*)(&llvm_libc_20_1_2_printf_core_PaddingWriter))[2] = -86;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_printf_core_PaddingWriter) + 3;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			ptr[4] = -86;
			((long*)(&llvm_libc_20_1_2_printf_core_PaddingWriter))[1] = -6148914691236517206L;
			PaddingWriter_Constructor.Invoke(&llvm_libc_20_1_2_printf_core_PaddingWriter, To_conv, init_sign_char);
			Llvm_lifetime_start_p0.Invoke(96L, &llvm_libc_20_1_2_printf_core_FloatWriter);
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_FloatWriter, -86, 96L, isVolatile: false);
			FloatWriter_Constructor.Invoke(&llvm_libc_20_1_2_printf_core_FloatWriter, Writer, (b & 1) == 1, &llvm_libc_20_1_2_printf_core_PaddingWriter);
			Llvm_lifetime_start_p0.Invoke(4320L, &llvm_libc_20_1_2_FloatToString_8m29tk);
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_FloatToString_8m29tk, -86, 4320L, isVolatile: false);
			FloatToString_long_double_0_Constructor.Invoke(&llvm_libc_20_1_2_FloatToString_8m29tk, FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi));
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = 0L;
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = 0;
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = -1431655766;
			num6 = (int)((num2 >= 0) ? FloatToString_long_double_0_get_positive_blocks.Invoke(&llvm_libc_20_1_2_FloatToString_8m29tk) : checked(-unchecked((int)FloatToString_long_double_0_zero_blocks_after_point.Invoke(&llvm_libc_20_1_2_FloatToString_8m29tk))));
			Llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = 0;
			if (NumericHelper.IntCmpNe(x, 0L))
			{
				while (num7 == 0)
				{
					num6 = checked(num6 + -1);
					num7 = FloatToString_long_double_0_get_block.Invoke(&llvm_libc_20_1_2_FloatToString_8m29tk, num6);
				}
			}
			else
			{
				num6 = 0;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num8);
			Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc);
			IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc, (uint)num7);
			long num21 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc);
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc);
			num8 = num21;
		}
		num5 = unchecked((int)(num6 * 9L)) + unchecked((int)(num8 - 1L));
		Llvm_lifetime_start_p0.Invoke(4L, &num9);
		num9 = ((num5 >= 0) ? num5 : (-num5));
		Llvm_lifetime_start_p0.Invoke(8L, &num10);
		Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc2);
		IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc2, num9);
		long num22 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc2);
		Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc2);
		num10 = num22;
		unchecked
		{
			FloatWriter_init.Invoke(&llvm_libc_20_1_2_printf_core_FloatWriter, (uint)(checked(1 + InstructionHelper.Select((b & 1) == 1, 1, 0)) + num3 + 2) + (((ulong)num10 >= 2uL) ? num10 : 2L), 1L);
			if ((ulong)num8 <= (ulong)(uint)(num3 + 1))
			{
				FloatWriter_write_first_block.Invoke(&llvm_libc_20_1_2_printf_core_FloatWriter, num7, Exp_format: true);
				num4 += num8;
				num6 = checked(num6 + -1);
			}
			while (true)
			{
				int num23;
				if ((ulong)(num4 + 9L) < (ulong)(uint)(num3 + 1))
				{
					num7 = FloatToString_long_double_0_get_block.Invoke(&llvm_libc_20_1_2_FloatToString_8m29tk, num6);
					Llvm_lifetime_start_p0.Invoke(4L, &num11);
					num11 = FloatWriter_write_middle_block.Invoke(&llvm_libc_20_1_2_printf_core_FloatWriter, num7);
					if (num11 < 0)
					{
						result = num11;
						num23 = 1;
					}
					else
					{
						num23 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num11);
					switch (num23)
					{
					case 0:
						goto IL_056b;
					}
					break;
				}
				num7 = FloatToString_long_double_0_get_block.Invoke(&llvm_libc_20_1_2_FloatToString_8m29tk, num6);
				Llvm_lifetime_start_p0.Invoke(8L, &num12);
				num12 = 9L;
				if (num4 == 0L)
				{
					Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc3);
					IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc3, (uint)num7);
					num12 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc3);
					Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc3);
				}
				Llvm_lifetime_start_p0.Invoke(1L, &b2);
				b2 = 0;
				Llvm_lifetime_start_p0.Invoke(8L, &num13);
				num13 = (uint)(num3 + 1) - num4;
				Llvm_lifetime_start_p0.Invoke(4L, &num14);
				num14 = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &i);
				for (i = 0; (ulong)(uint)i < (ulong)(num12 - num13); i++)
				{
					if (num14 != 0)
					{
						b2 = 1;
					}
					num14 = (int)((uint)num7 % 10u);
					num7 = (int)((uint)num7 / 10u);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &i);
				if (num13 == num12)
				{
					num6 = checked(num6 + -1);
					Llvm_lifetime_start_p0.Invoke(4L, &num15);
					num15 = FloatToString_long_double_0_get_block.Invoke(&llvm_libc_20_1_2_FloatToString_8m29tk, num6);
					num14 = (int)((uint)num15 / 100000000u);
					if ((uint)num15 % 100000000u != 0)
					{
						b2 = 1;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num15);
				}
				Llvm_lifetime_start_p0.Invoke(4L, &round);
				round = -1431655766;
				int last_digit;
				bool truncated;
				checked
				{
					if ((b2 & 1) != 1)
					{
						if (num6 >= 0)
						{
							Llvm_lifetime_start_p0.Invoke(4L, &j);
							for (j = num6 - 1; j >= 0; j += -1)
							{
								Llvm_lifetime_start_p0.Invoke(4L, &num16);
								num16 = FloatToString_long_double_0_get_block.Invoke(&llvm_libc_20_1_2_FloatToString_8m29tk, j);
								if (num16 != 0)
								{
									b2 = 1;
									num23 = 10;
								}
								else
								{
									num23 = 0;
								}
								Llvm_lifetime_end_p0.Invoke(4L, &num16);
								switch (num23)
								{
								case 0:
									continue;
								}
								break;
							}
							Llvm_lifetime_end_p0.Invoke(4L, &j);
						}
						if ((b2 & 1) != 1 && num2 - 63 < 0)
						{
							int base_2_exp = num2 - 63;
							unchecked
							{
								int digits_after_point = num3 - num5;
								Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
								Int128* num24 = &int2;
								Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
								*(long*)num24 = struct_fiz2nb5.field_0;
								byte* num25 = (byte*)(&int2) + 8u;
								Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
								*(long*)num25 = struct_fiz2nb6.field_1;
								int3 = int2;
								b2 = (InstructionHelper.BooleanXor(Printf_core_zero_after_digits_unsigned_int128.Invoke(base_2_exp, digits_after_point, *(long*)(&int3), ((long*)(&int3))[1], 63), right: true) ? ((sbyte)1) : ((sbyte)0));
							}
						}
					}
					last_digit = num14;
					truncated = (b2 & 1) == 1;
					anon_izyfb.Val = FPStorage_fputil_FPType_4_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				}
				round = (int)Printf_core_get_round_direction.Invoke(last_digit, truncated, anon_izyfb.Val);
				Llvm_lifetime_start_p0.Invoke(4L, &num17);
				num17 = FloatWriter_write_last_block.Invoke(&llvm_libc_20_1_2_printf_core_FloatWriter, num7, num13, (RoundDirection_zvveyk)round, num5, InstructionHelper.Select(Internal_islower_qy8nhx.Invoke(To_conv->Conv_name), (sbyte)101, (sbyte)69));
				if (num17 < 0)
				{
					result = num17;
					num23 = 1;
				}
				else
				{
					num23 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num17);
				switch (num23)
				{
				case 0:
					Llvm_lifetime_start_p0.Invoke(4L, &num18);
					num18 = FloatWriter_right_pad.Invoke(&llvm_libc_20_1_2_printf_core_FloatWriter);
					if (num18 < 0)
					{
						result = num18;
						num23 = 1;
					}
					else
					{
						num23 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num18);
					switch (num23)
					{
					case 0:
						result = 0;
						break;
					}
					break;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &round);
				Llvm_lifetime_end_p0.Invoke(4L, &num14);
				Llvm_lifetime_end_p0.Invoke(8L, &num13);
				Llvm_lifetime_end_p0.Invoke(1L, &b2);
				Llvm_lifetime_end_p0.Invoke(8L, &num12);
				break;
				IL_056b:
				num4 += 9L;
				num6 = checked(num6 + -1);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num10);
			Llvm_lifetime_end_p0.Invoke(4L, &num9);
			Llvm_lifetime_end_p0.Invoke(8L, &num8);
			Llvm_lifetime_end_p0.Invoke(4L, &num7);
			Llvm_lifetime_end_p0.Invoke(4L, &num6);
			Llvm_lifetime_end_p0.Invoke(4L, &num5);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(4320L, &llvm_libc_20_1_2_FloatToString_8m29tk);
			Llvm_lifetime_end_p0.Invoke(96L, &llvm_libc_20_1_2_printf_core_FloatWriter);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_printf_core_PaddingWriter);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(1L, &init_sign_char);
			Llvm_lifetime_end_p0.Invoke(16L, &x);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
