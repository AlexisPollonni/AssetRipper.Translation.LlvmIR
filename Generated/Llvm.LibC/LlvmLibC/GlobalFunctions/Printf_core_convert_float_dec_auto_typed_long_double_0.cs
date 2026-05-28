using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_convert_float_dec_auto_typed_long_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core28convert_float_dec_auto_typedIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiPNS0_6WriterERKNS0_13FormatSectionENS_6fputil6FPBitsIS4_EE")]
	[DemangledName("int __llvm_libc_20_1_2_::printf_core::convert_float_dec_auto_typed<long double, 0>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&, __llvm_libc_20_1_2_::fputil::FPBits<long double>)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("writer")] Printf_core_Writer* Writer, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Printf_core_FormatSection* To_conv, [MangledName("float_bits.coerce0")][NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection const&")] long Float_bits, [MangledName("float_bits.coerce1")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<long double>")] long FRACTION_LEN)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		int num = 0;
		int num2 = 0;
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		FloatToString_8m29tk floatToString_8m29tk = default(FloatToString_8m29tk);
		int num6 = 0;
		int num7 = 0;
		Printf_core_FormatSection printf_core_FormatSection = default(Printf_core_FormatSection);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		long num8 = 0L;
		IntegerToString_uuwdyc integerToString_uuwdyc = default(IntegerToString_uuwdyc);
		long num9 = 0L;
		long num10 = 0L;
		long num11 = 0L;
		IntegerToString_uuwdyc integerToString_uuwdyc2 = default(IntegerToString_uuwdyc);
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		long num12 = 0L;
		int num13 = 0;
		int num14 = 0;
		long num15 = 0L;
		IntegerToString_uuwdyc integerToString_uuwdyc3 = default(IntegerToString_uuwdyc);
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		long num16 = 0L;
		int num17 = 0;
		int num18 = 0;
		int i = 0;
		sbyte b = 0;
		int num19 = 0;
		int num20 = 0;
		int j = 0;
		int num21 = 0;
		int num22 = 0;
		int k = 0;
		int num23 = 0;
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		sbyte b2 = 0;
		int num24 = 0;
		Printf_core_FormatSection printf_core_FormatSection2 = default(Printf_core_FormatSection);
		int num25 = 0;
		int num26 = 0;
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(Fputil_FPBits_ubgsi2);
		int num27 = 0;
		Printf_core_FormatSection printf_core_FormatSection3 = default(Printf_core_FormatSection);
		int num28 = 0;
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(Fputil_FPBits_ubgsi2);
		unchecked
		{
			*(long*)(&fputil_FPBits_ubgsi) = Float_bits;
			((long*)(&fputil_FPBits_ubgsi))[1] = FRACTION_LEN;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 63;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_exponent.Invoke(&fputil_FPBits_ubgsi);
			Llvm_lifetime_start_p0.Invoke(16L, &x);
			Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&fputil_FPBits_ubgsi);
			Int128* num29 = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num29 = struct_fiz2nb2.field_0;
			byte* num30 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num30 = struct_fiz2nb3.field_1;
			x = @int;
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = ((To_conv->Precision > 0) ? To_conv->Precision : InstructionHelper.Select(To_conv->Precision == 0, 1, 6));
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = 0;
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = num3 - 1;
			Llvm_lifetime_start_p0.Invoke(4320L, &floatToString_8m29tk);
			Llvm_memset_p0_i64.Invoke(&floatToString_8m29tk, -86, 4320L, isVolatile: false);
			FloatToString_long_double_0_Constructor.Invoke(&floatToString_8m29tk, FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi));
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = -1431655766;
			num6 = (int)((num2 >= 0) ? FloatToString_long_double_0_get_positive_blocks.Invoke(&floatToString_8m29tk) : checked(-unchecked((int)FloatToString_long_double_0_zero_blocks_after_point.Invoke(&floatToString_8m29tk))));
			Llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = 0;
			int result;
			if (NumericHelper.IntCmpNe(x, 0L))
			{
				while (num7 == 0)
				{
					num6 = checked(num6 + -1);
					num7 = FloatToString_long_double_0_get_block.Invoke(&floatToString_8m29tk, num6);
				}
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				Llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc);
				IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&integerToString_uuwdyc, (uint)num7);
				long num31 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size.Invoke(&integerToString_uuwdyc);
				Llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc);
				num8 = num31;
				Llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = 0L;
				Llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = 0L;
				Llvm_lifetime_start_p0.Invoke(8L, &num11);
				num11 = 0L;
				checked
				{
					num4 = unchecked((int)(num6 * 9L)) + unchecked((int)(num8 - 1L));
				}
				if ((ulong)num8 <= (ulong)(uint)(num5 + 1))
				{
					Llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc2);
					sbyte* ptr = (sbyte*)(&integerToString_uuwdyc2);
					*ptr = -86;
					ptr[1] = -86;
					ptr[2] = -86;
					ptr[3] = -86;
					ptr[4] = -86;
					ptr[5] = -86;
					ptr[6] = -86;
					ptr[7] = -86;
					ptr[8] = -86;
					ptr[9] = -86;
					ptr[10] = -86;
					ptr[11] = -86;
					ptr[12] = -86;
					ptr[13] = -86;
					ptr[14] = -86;
					ptr[15] = -86;
					ptr[16] = -86;
					ptr[17] = -86;
					ptr[18] = -86;
					ptr[19] = -86;
					ptr[20] = -86;
					sbyte* ptr2 = (sbyte*)(&integerToString_uuwdyc2) + 21;
					*ptr2 = -86;
					ptr2[1] = -86;
					ptr2[2] = -86;
					((long*)(&integerToString_uuwdyc2))[3] = -6148914691236517206L;
					IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&integerToString_uuwdyc2, (uint)num7);
					Llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view);
					*(IntPtr*)(&cpp_string_view) = unchecked((nint)(-6148914691236517206L));
					((long*)(&cpp_string_view))[1] = -6148914691236517206L;
					Struct_kqhe8i struct_kqhe8i = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view.Invoke(&integerToString_uuwdyc2);
					Cpp_string_view* num32 = &cpp_string_view;
					Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
					*(void**)num32 = struct_kqhe8i2.field_0;
					byte* num33 = (byte*)(&cpp_string_view) + 8u;
					Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
					*(long*)num33 = struct_kqhe8i3.field_1;
					Llvm_lifetime_start_p0.Invoke(8L, &num12);
					for (num12 = 0L; (ulong)num12 < (ulong)num8; num12++)
					{
						if (*(sbyte*)String_view_Index.Invoke(&cpp_string_view, num12) == 57)
						{
							num11++;
							num10 = 0L;
						}
						else if (*(sbyte*)String_view_Index.Invoke(&cpp_string_view, num12) == 48)
						{
							num10++;
							num11 = 0L;
						}
						else
						{
							num11 = 0L;
							num10 = 0L;
						}
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num12);
					num9 += num8;
					num6 = checked(num6 + -1);
					Llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view);
					Llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc2);
				}
				while ((ulong)(num9 + 9L) < (ulong)(uint)(num5 + 1))
				{
					num7 = FloatToString_long_double_0_get_block.Invoke(&floatToString_8m29tk, num6);
					num9 += 9L;
					switch (num7)
					{
					case 999999999:
						num11 += 9L;
						num10 = 0L;
						break;
					case 0:
						num10 += 9L;
						num11 = 0L;
						break;
					default:
						num11 = 0L;
						num10 = 0L;
						Llvm_lifetime_start_p0.Invoke(4L, &num13);
						num13 = num7;
						Llvm_lifetime_start_p0.Invoke(4L, &num14);
						for (num14 = (int)((uint)num13 % 10u); num13 != 0 && (num14 == 9 || num14 == 0) && (uint)num13 % 10u == (uint)num14; num13 = (int)((uint)num13 / 10u))
						{
							switch (num14)
							{
							case 9:
								num11++;
								continue;
							case 0:
								num10++;
								continue;
							}
							break;
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num14);
						Llvm_lifetime_end_p0.Invoke(4L, &num13);
						break;
					}
					num6 = checked(num6 + -1);
				}
				num7 = FloatToString_long_double_0_get_block.Invoke(&floatToString_8m29tk, num6);
				Llvm_lifetime_start_p0.Invoke(8L, &num15);
				num15 = 9L;
				Llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc3);
				sbyte* ptr3 = (sbyte*)(&integerToString_uuwdyc3);
				*ptr3 = -86;
				ptr3[1] = -86;
				ptr3[2] = -86;
				ptr3[3] = -86;
				ptr3[4] = -86;
				ptr3[5] = -86;
				ptr3[6] = -86;
				ptr3[7] = -86;
				ptr3[8] = -86;
				ptr3[9] = -86;
				ptr3[10] = -86;
				ptr3[11] = -86;
				ptr3[12] = -86;
				ptr3[13] = -86;
				ptr3[14] = -86;
				ptr3[15] = -86;
				ptr3[16] = -86;
				ptr3[17] = -86;
				ptr3[18] = -86;
				ptr3[19] = -86;
				ptr3[20] = -86;
				sbyte* ptr4 = (sbyte*)(&integerToString_uuwdyc3) + 21;
				*ptr4 = -86;
				ptr4[1] = -86;
				ptr4[2] = -86;
				((long*)(&integerToString_uuwdyc3))[3] = -6148914691236517206L;
				IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&integerToString_uuwdyc3, (uint)num7);
				Llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
				*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
				((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
				Struct_kqhe8i struct_kqhe8i4 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view.Invoke(&integerToString_uuwdyc3);
				Cpp_string_view* num34 = &cpp_string_view2;
				Struct_kqhe8i struct_kqhe8i5 = struct_kqhe8i4;
				*(void**)num34 = struct_kqhe8i5.field_0;
				byte* num35 = (byte*)(&cpp_string_view2) + 8u;
				Struct_kqhe8i struct_kqhe8i6 = struct_kqhe8i4;
				*(long*)num35 = struct_kqhe8i6.field_1;
				Llvm_lifetime_start_p0.Invoke(8L, &num16);
				num16 = 9L - String_view_size.Invoke(&cpp_string_view2);
				if (num9 == 0L)
				{
					num15 = String_view_size.Invoke(&cpp_string_view2);
					num16 = 0L;
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num17);
				num17 = num5 + 1 - (int)num9;
				Llvm_lifetime_start_p0.Invoke(4L, &num18);
				num18 = num17 - (int)num16;
				if (num18 < 0)
				{
					num18 = 0;
				}
				if ((ulong)num16 > 0uL)
				{
					num11 = 0L;
				}
				num10 += (((ulong)num16 <= (ulong)(uint)num17) ? num16 : ((uint)num17));
				Llvm_lifetime_start_p0.Invoke(4L, &i);
				for (i = 0; i < num18; i = checked(i + 1))
				{
					if (*(sbyte*)String_view_Index.Invoke(&cpp_string_view2, i) == 57)
					{
						num11++;
						num10 = 0L;
					}
					else if (*(sbyte*)String_view_Index.Invoke(&cpp_string_view2, i) == 48)
					{
						num10++;
						num11 = 0L;
					}
					else
					{
						num11 = 0L;
						num10 = 0L;
					}
				}
				Llvm_lifetime_end_p0.Invoke(4L, &i);
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				b = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &num19);
				num19 = num5 + 1 - (int)num9;
				Llvm_lifetime_start_p0.Invoke(4L, &num20);
				num20 = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &j);
				for (j = 0; (ulong)(uint)j < (ulong)(num15 - (uint)num19); j++)
				{
					if (num20 != 0)
					{
						b = 1;
					}
					num20 = (int)((uint)num7 % 10u);
					num7 = (int)((uint)num7 / 10u);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &j);
				if ((uint)num19 == num15)
				{
					num6 = checked(num6 + -1);
					Llvm_lifetime_start_p0.Invoke(4L, &num21);
					num21 = FloatToString_long_double_0_get_block.Invoke(&floatToString_8m29tk, num6);
					num20 = (int)((uint)num21 / 100000000u);
					if ((uint)num21 % 100000000u != 0)
					{
						b = 1;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num21);
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num22);
				num22 = -1431655766;
				int last_digit;
				bool truncated;
				checked
				{
					if ((b & 1) != 1)
					{
						if (num6 >= 0)
						{
							Llvm_lifetime_start_p0.Invoke(4L, &k);
							for (k = num6 - 1; k >= 0; k += -1)
							{
								Llvm_lifetime_start_p0.Invoke(4L, &num23);
								num23 = FloatToString_long_double_0_get_block.Invoke(&floatToString_8m29tk, k);
								int num36;
								if (num23 != 0)
								{
									b = 1;
									num36 = 18;
								}
								else
								{
									num36 = 0;
								}
								Llvm_lifetime_end_p0.Invoke(4L, &num23);
								switch (num36)
								{
								case 0:
									continue;
								}
								break;
							}
							Llvm_lifetime_end_p0.Invoke(4L, &k);
						}
						if ((b & 1) != 1 && num2 - 63 < 0)
						{
							int base_2_exp = num2 - 63;
							unchecked
							{
								int digits_after_point = num5 - num4;
								Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&fputil_FPBits_ubgsi);
								Int128* num37 = &int2;
								Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
								*(long*)num37 = struct_fiz2nb5.field_0;
								byte* num38 = (byte*)(&int2) + 8u;
								Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
								*(long*)num38 = struct_fiz2nb6.field_1;
								int3 = int2;
								b = (InstructionHelper.BooleanXor(Printf_core_zero_after_digits_unsigned_int128.Invoke(base_2_exp, digits_after_point, *(long*)(&int3), ((long*)(&int3))[1], 63), right: true) ? ((sbyte)1) : ((sbyte)0));
							}
						}
					}
					last_digit = num20;
					truncated = (b & 1) == 1;
					anon_izyfb.Val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi);
				}
				num22 = (int)Printf_core_get_round_direction.Invoke(last_digit, truncated, anon_izyfb.Val);
				Llvm_lifetime_start_p0.Invoke(1L, &b2);
				b2 = -86;
				switch (num22)
				{
				case 0:
					b2 = 1;
					break;
				case 1:
					b2 = 0;
					break;
				default:
					Llvm_lifetime_start_p0.Invoke(4L, &num24);
					num24 = -1431655766;
					num24 = ((num19 == 0) ? (((ulong)num11 <= 0uL) ? (((ulong)num10 <= 0uL) ? 0 : 0) : 9) : ((int)((uint)num7 % 10u)));
					b2 = (((uint)num24 % 2u != 0) ? ((sbyte)1) : ((sbyte)0));
					Llvm_lifetime_end_p0.Invoke(4L, &num24);
					break;
				}
				num9 += (uint)num17;
				if ((b2 & 1) == 1)
				{
					if (num11 == (uint)num3)
					{
						num4 = checked(num4 + 1);
						num10 = num9;
						num9++;
					}
					else if ((ulong)num11 > 0uL)
					{
						num10 += num11;
					}
					else if ((ulong)num10 > 0uL)
					{
						num10 = 0L;
					}
				}
				if (num3 > num4 && num4 >= -4)
				{
					Llvm_lifetime_start_p0.Invoke(80L, &printf_core_FormatSection2);
					Llvm_memset_p0_i64.Invoke(&printf_core_FormatSection2, -86, 80L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&printf_core_FormatSection2, To_conv, 80L, isVolatile: false);
					Llvm_lifetime_start_p0.Invoke(4L, &num25);
					num25 = num3 - checked(num4 + 1);
					if (((byte)To_conv->Flags & 8) != 0)
					{
						printf_core_FormatSection2.Precision = num25;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num26);
						num26 = (int)(num9 - checked(num4 + 1) - num10);
						if (num26 < 0)
						{
							num26 = 0;
						}
						printf_core_FormatSection2.Precision = ((num26 <= num25) ? num26 : num25);
						Llvm_lifetime_end_p0.Invoke(4L, &num26);
					}
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi, 16L, isVolatile: false);
					result = Printf_core_convert_float_decimal_typed_long_double_0.Invoke(Writer, &printf_core_FormatSection2, *(long*)(&fputil_FPBits_ubgsi3), ((long*)(&fputil_FPBits_ubgsi3))[1]);
					Llvm_lifetime_end_p0.Invoke(4L, &num25);
					Llvm_lifetime_end_p0.Invoke(80L, &printf_core_FormatSection2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num27);
					num27 = num3 - 1;
					Llvm_lifetime_start_p0.Invoke(80L, &printf_core_FormatSection3);
					Llvm_memset_p0_i64.Invoke(&printf_core_FormatSection3, -86, 80L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&printf_core_FormatSection3, To_conv, 80L, isVolatile: false);
					if (((byte)To_conv->Flags & 8) != 0)
					{
						printf_core_FormatSection3.Precision = num27;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num28);
						num28 = (int)(num9 - 1L - num10);
						if (num28 < 0)
						{
							num28 = 0;
						}
						printf_core_FormatSection3.Precision = ((num28 <= num27) ? num28 : num27);
						Llvm_lifetime_end_p0.Invoke(4L, &num28);
					}
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi4, &fputil_FPBits_ubgsi, 16L, isVolatile: false);
					result = Printf_core_convert_float_dec_exp_typed_long_double_0.Invoke(Writer, &printf_core_FormatSection3, *(long*)(&fputil_FPBits_ubgsi4), ((long*)(&fputil_FPBits_ubgsi4))[1]);
					Llvm_lifetime_end_p0.Invoke(80L, &printf_core_FormatSection3);
					Llvm_lifetime_end_p0.Invoke(4L, &num27);
				}
				Llvm_lifetime_end_p0.Invoke(1L, &b2);
				Llvm_lifetime_end_p0.Invoke(4L, &num22);
				Llvm_lifetime_end_p0.Invoke(4L, &num20);
				Llvm_lifetime_end_p0.Invoke(4L, &num19);
				Llvm_lifetime_end_p0.Invoke(1L, &b);
				Llvm_lifetime_end_p0.Invoke(4L, &num18);
				Llvm_lifetime_end_p0.Invoke(4L, &num17);
				Llvm_lifetime_end_p0.Invoke(8L, &num16);
				Llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
				Llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc3);
				Llvm_lifetime_end_p0.Invoke(8L, &num15);
				Llvm_lifetime_end_p0.Invoke(8L, &num11);
				Llvm_lifetime_end_p0.Invoke(8L, &num10);
				Llvm_lifetime_end_p0.Invoke(8L, &num9);
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(80L, &printf_core_FormatSection);
				Llvm_memset_p0_i64.Invoke(&printf_core_FormatSection, -86, 80L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&printf_core_FormatSection, To_conv, 80L, isVolatile: false);
				if (((byte)To_conv->Flags & 8) != 0)
				{
					printf_core_FormatSection.Precision = num3 - 1;
				}
				else
				{
					printf_core_FormatSection.Precision = 0;
				}
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi2, &fputil_FPBits_ubgsi, 16L, isVolatile: false);
				result = Printf_core_convert_float_decimal_typed_long_double_0.Invoke(Writer, &printf_core_FormatSection, *(long*)(&fputil_FPBits_ubgsi2), ((long*)(&fputil_FPBits_ubgsi2))[1]);
				Llvm_lifetime_end_p0.Invoke(80L, &printf_core_FormatSection);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num7);
			Llvm_lifetime_end_p0.Invoke(4L, &num6);
			Llvm_lifetime_end_p0.Invoke(4320L, &floatToString_8m29tk);
			Llvm_lifetime_end_p0.Invoke(4L, &num5);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(16L, &x);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
