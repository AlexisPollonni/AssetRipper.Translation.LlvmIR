using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core28convert_float_dec_auto_typedIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiPNS0_6WriterERKNS0_13FormatSectionENS_6fputil6FPBitsIS4_EE")]
[DemangledName("int __llvm_libc_20_1_2_::printf_core::convert_float_dec_auto_typed<double, 0>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&, __llvm_libc_20_1_2_::fputil::FPBits<double>)")]
internal static partial class int_printf_core_convert_float_dec_auto_typed_double_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_double
{
	public unsafe static int Invoke(printf_core_Writer* writer, printf_core_FormatSection* to_conv, [MangledName("float_bits.coerce")] long float_bits)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		int num = 0;
		int num2 = 0;
		Int128 x = default(Int128);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		FloatToString_rwjwy3 floatToString_rwjwy = default(FloatToString_rwjwy3);
		int num6 = 0;
		int num7 = 0;
		printf_core_FormatSection printf_core_FormatSection2 = default(printf_core_FormatSection);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		long num8 = 0L;
		IntegerToString_uuwdyc integerToString_uuwdyc = default(IntegerToString_uuwdyc);
		long num9 = 0L;
		long num10 = 0L;
		long num11 = 0L;
		IntegerToString_uuwdyc integerToString_uuwdyc2 = default(IntegerToString_uuwdyc);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		long num12 = 0L;
		int num13 = 0;
		int num14 = 0;
		long num15 = 0L;
		IntegerToString_uuwdyc integerToString_uuwdyc3 = default(IntegerToString_uuwdyc);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
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
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		sbyte b2 = 0;
		int num24 = 0;
		printf_core_FormatSection printf_core_FormatSection3 = default(printf_core_FormatSection);
		int num25 = 0;
		int num26 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		int num27 = 0;
		printf_core_FormatSection printf_core_FormatSection4 = default(printf_core_FormatSection);
		int num28 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = float_bits;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 52;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		unchecked
		{
			num2 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_explicit_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(16L, &x);
			x = (Int128)(UInt128)(ulong)fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = ((to_conv->precision > 0) ? to_conv->precision : InstructionHelper.Select(to_conv->precision == 0, 1, 6));
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = 0;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = num3 - 1;
			llvm_lifetime_start_p0.Invoke(32L, &floatToString_rwjwy);
			*(long*)(&floatToString_rwjwy) = -6148914691236517206L;
			((int*)(&floatToString_rwjwy))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&floatToString_rwjwy) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			*(Int128*)((byte*)(&floatToString_rwjwy) + 16) = -6148914691236517206L;
			FloatToString_double_0_FloatToString_double.Invoke(&floatToString_rwjwy, fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = -1431655766;
			num6 = (int)((num2 >= 0) ? FloatToString_double_0_get_positive_blocks.Invoke(&floatToString_rwjwy) : checked(-unchecked((int)FloatToString_double_0_zero_blocks_after_point.Invoke(&floatToString_rwjwy))));
			llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = 0;
			int result;
			if (NumericHelper.IntCmpNe(x, 0L))
			{
				while (num7 == 0)
				{
					num6 = checked(num6 + -1);
					num7 = FloatToString_double_0_get_block_int.Invoke(&floatToString_rwjwy, num6);
				}
				llvm_lifetime_start_p0.Invoke(8L, &num8);
				llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc);
				IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerToString_long.Invoke(&integerToString_uuwdyc, (uint)num7);
				long num29 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size_const.Invoke(&integerToString_uuwdyc);
				llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc);
				num8 = num29;
				llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = 0L;
				llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = 0L;
				llvm_lifetime_start_p0.Invoke(8L, &num11);
				num11 = 0L;
				checked
				{
					num4 = unchecked((int)(num6 * 9L)) + unchecked((int)(num8 - 1L));
				}
				if ((ulong)num8 <= (ulong)(uint)(num5 + 1))
				{
					llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc2);
					sbyte* ptr2 = (sbyte*)(&integerToString_uuwdyc2);
					*ptr2 = -86;
					ptr2[1] = -86;
					ptr2[2] = -86;
					ptr2[3] = -86;
					ptr2[4] = -86;
					ptr2[5] = -86;
					ptr2[6] = -86;
					ptr2[7] = -86;
					ptr2[8] = -86;
					ptr2[9] = -86;
					ptr2[10] = -86;
					ptr2[11] = -86;
					ptr2[12] = -86;
					ptr2[13] = -86;
					ptr2[14] = -86;
					ptr2[15] = -86;
					ptr2[16] = -86;
					ptr2[17] = -86;
					ptr2[18] = -86;
					ptr2[19] = -86;
					ptr2[20] = -86;
					sbyte* ptr3 = (sbyte*)(&integerToString_uuwdyc2) + 21;
					*ptr3 = -86;
					ptr3[1] = -86;
					ptr3[2] = -86;
					((long*)(&integerToString_uuwdyc2))[3] = -6148914691236517206L;
					IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerToString_long.Invoke(&integerToString_uuwdyc2, (uint)num7);
					llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
					*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
					((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
					Struct_kqhe8i struct_kqhe8i = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view_const.Invoke(&integerToString_uuwdyc2);
					cpp_string_view* num30 = &cpp_string_view2;
					Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
					*(void**)num30 = struct_kqhe8i2.field_0;
					byte* num31 = (byte*)(&cpp_string_view2) + 8u;
					Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
					*(long*)num31 = struct_kqhe8i3.field_1;
					llvm_lifetime_start_p0.Invoke(8L, &num12);
					for (num12 = 0L; (ulong)num12 < (ulong)num8; num12++)
					{
						if (*(sbyte*)cpp_string_view_operator_unsigned_long_const.Invoke(&cpp_string_view2, num12) == 57)
						{
							num11++;
							num10 = 0L;
						}
						else if (*(sbyte*)cpp_string_view_operator_unsigned_long_const.Invoke(&cpp_string_view2, num12) == 48)
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
					llvm_lifetime_end_p0.Invoke(8L, &num12);
					num9 += num8;
					num6 = checked(num6 + -1);
					llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
					llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc2);
				}
				while ((ulong)(num9 + 9L) < (ulong)(uint)(num5 + 1))
				{
					num7 = FloatToString_double_0_get_block_int.Invoke(&floatToString_rwjwy, num6);
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
						llvm_lifetime_start_p0.Invoke(4L, &num13);
						num13 = num7;
						llvm_lifetime_start_p0.Invoke(4L, &num14);
						for (num14 = (int)((uint)num13 % 10u); num13 != 0 && ((num14 != 9) ? (num14 == 0) : true) && (uint)num13 % 10u == (uint)num14; num13 = (int)((uint)num13 / 10u))
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
						llvm_lifetime_end_p0.Invoke(4L, &num14);
						llvm_lifetime_end_p0.Invoke(4L, &num13);
						break;
					}
					num6 = checked(num6 + -1);
				}
				num7 = FloatToString_double_0_get_block_int.Invoke(&floatToString_rwjwy, num6);
				llvm_lifetime_start_p0.Invoke(8L, &num15);
				num15 = 9L;
				llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc3);
				sbyte* ptr4 = (sbyte*)(&integerToString_uuwdyc3);
				*ptr4 = -86;
				ptr4[1] = -86;
				ptr4[2] = -86;
				ptr4[3] = -86;
				ptr4[4] = -86;
				ptr4[5] = -86;
				ptr4[6] = -86;
				ptr4[7] = -86;
				ptr4[8] = -86;
				ptr4[9] = -86;
				ptr4[10] = -86;
				ptr4[11] = -86;
				ptr4[12] = -86;
				ptr4[13] = -86;
				ptr4[14] = -86;
				ptr4[15] = -86;
				ptr4[16] = -86;
				ptr4[17] = -86;
				ptr4[18] = -86;
				ptr4[19] = -86;
				ptr4[20] = -86;
				sbyte* ptr5 = (sbyte*)(&integerToString_uuwdyc3) + 21;
				*ptr5 = -86;
				ptr5[1] = -86;
				ptr5[2] = -86;
				((long*)(&integerToString_uuwdyc3))[3] = -6148914691236517206L;
				IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerToString_long.Invoke(&integerToString_uuwdyc3, (uint)num7);
				llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view3);
				*(IntPtr*)(&cpp_string_view3) = unchecked((nint)(-6148914691236517206L));
				((long*)(&cpp_string_view3))[1] = -6148914691236517206L;
				Struct_kqhe8i struct_kqhe8i4 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view_const.Invoke(&integerToString_uuwdyc3);
				cpp_string_view* num32 = &cpp_string_view3;
				Struct_kqhe8i struct_kqhe8i5 = struct_kqhe8i4;
				*(void**)num32 = struct_kqhe8i5.field_0;
				byte* num33 = (byte*)(&cpp_string_view3) + 8u;
				Struct_kqhe8i struct_kqhe8i6 = struct_kqhe8i4;
				*(long*)num33 = struct_kqhe8i6.field_1;
				llvm_lifetime_start_p0.Invoke(8L, &num16);
				num16 = 9L - cpp_string_view_size_const.Invoke(&cpp_string_view3);
				if (num9 == 0L)
				{
					num15 = cpp_string_view_size_const.Invoke(&cpp_string_view3);
					num16 = 0L;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num17);
				num17 = num5 + 1 - (int)num9;
				llvm_lifetime_start_p0.Invoke(4L, &num18);
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
				llvm_lifetime_start_p0.Invoke(4L, &i);
				for (i = 0; i < num18; i = checked(i + 1))
				{
					if (*(sbyte*)cpp_string_view_operator_unsigned_long_const.Invoke(&cpp_string_view3, i) == 57)
					{
						num11++;
						num10 = 0L;
					}
					else if (*(sbyte*)cpp_string_view_operator_unsigned_long_const.Invoke(&cpp_string_view3, i) == 48)
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
				llvm_lifetime_end_p0.Invoke(4L, &i);
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = 0;
				llvm_lifetime_start_p0.Invoke(4L, &num19);
				num19 = num5 + 1 - (int)num9;
				llvm_lifetime_start_p0.Invoke(4L, &num20);
				num20 = 0;
				llvm_lifetime_start_p0.Invoke(4L, &j);
				for (j = 0; (ulong)(uint)j < (ulong)(num15 - (uint)num19); j++)
				{
					if (num20 != 0)
					{
						b = 1;
					}
					num20 = (int)((uint)num7 % 10u);
					num7 = (int)((uint)num7 / 10u);
				}
				llvm_lifetime_end_p0.Invoke(4L, &j);
				if ((uint)num19 == num15)
				{
					num6 = checked(num6 + -1);
					llvm_lifetime_start_p0.Invoke(4L, &num21);
					num21 = FloatToString_double_0_get_block_int.Invoke(&floatToString_rwjwy, num6);
					num20 = (int)((uint)num21 / 100000000u);
					if ((uint)num21 % 100000000u != 0)
					{
						b = 1;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num21);
				}
				llvm_lifetime_start_p0.Invoke(4L, &num22);
				num22 = -1431655766;
				if ((b & 1) != 1)
				{
					checked
					{
						if (num6 >= 0)
						{
							llvm_lifetime_start_p0.Invoke(4L, &k);
							for (k = num6 - 1; k >= 0; k += -1)
							{
								llvm_lifetime_start_p0.Invoke(4L, &num23);
								num23 = FloatToString_double_0_get_block_int.Invoke(&floatToString_rwjwy, k);
								int num34;
								if (num23 != 0)
								{
									b = 1;
									num34 = 18;
								}
								else
								{
									num34 = 0;
								}
								llvm_lifetime_end_p0.Invoke(4L, &num23);
								switch (num34)
								{
								case 0:
									continue;
								}
								break;
							}
							llvm_lifetime_end_p0.Invoke(4L, &k);
						}
					}
					if ((b & 1) != 1 && checked(num2 - 52) < 0)
					{
						b = (sbyte)(byte)((cpp_enable_if_cpp_is_integral_v_unsigned_long_is_big_int_v_unsigned_long_bool_type_printf_core_zero_after_digits_unsigned_long_int_int_unsigned_long_int.Invoke(checked(num2 - 52), num5 - num4, fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)), 52) ? 1 : 0) ^ -1);
					}
				}
				int last_digit = num20;
				bool truncated = (b & 1) == 1;
				anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
				num22 = (int)printf_core_get_round_direction_int_bool_Sign.Invoke(last_digit, truncated, anon_izyfb8.val);
				llvm_lifetime_start_p0.Invoke(1L, &b2);
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
					llvm_lifetime_start_p0.Invoke(4L, &num24);
					num24 = -1431655766;
					num24 = ((num19 == 0) ? (((ulong)num11 <= 0uL) ? (((ulong)num10 <= 0uL) ? 0 : 0) : 9) : ((int)((uint)num7 % 10u)));
					b2 = (((uint)num24 % 2u != 0) ? ((sbyte)1) : ((sbyte)0));
					llvm_lifetime_end_p0.Invoke(4L, &num24);
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
					llvm_lifetime_start_p0.Invoke(80L, &printf_core_FormatSection3);
					llvm_memset_p0_i64.Invoke(&printf_core_FormatSection3, -86, 80L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&printf_core_FormatSection3, to_conv, 80L, isVolatile: false);
					llvm_lifetime_start_p0.Invoke(4L, &num25);
					num25 = num3 - checked(num4 + 1);
					if (((byte)to_conv->flags & 8) != 0)
					{
						printf_core_FormatSection3.precision = num25;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &num26);
						num26 = (int)(num9 - checked(num4 + 1) - num10);
						if (num26 < 0)
						{
							num26 = 0;
						}
						printf_core_FormatSection3.precision = ((num26 <= num25) ? num26 : num25);
						llvm_lifetime_end_p0.Invoke(4L, &num26);
					}
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm4, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
					result = int_printf_core_convert_float_decimal_typed_double_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_double.Invoke(writer, &printf_core_FormatSection3, fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val);
					llvm_lifetime_end_p0.Invoke(4L, &num25);
					llvm_lifetime_end_p0.Invoke(80L, &printf_core_FormatSection3);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num27);
					num27 = num3 - 1;
					llvm_lifetime_start_p0.Invoke(80L, &printf_core_FormatSection4);
					llvm_memset_p0_i64.Invoke(&printf_core_FormatSection4, -86, 80L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&printf_core_FormatSection4, to_conv, 80L, isVolatile: false);
					if (((byte)to_conv->flags & 8) != 0)
					{
						printf_core_FormatSection4.precision = num27;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &num28);
						num28 = (int)(num9 - 1L - num10);
						if (num28 < 0)
						{
							num28 = 0;
						}
						printf_core_FormatSection4.precision = ((num28 <= num27) ? num28 : num27);
						llvm_lifetime_end_p0.Invoke(4L, &num28);
					}
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm5, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
					result = int_printf_core_convert_float_dec_exp_typed_double_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_double.Invoke(writer, &printf_core_FormatSection4, fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val);
					llvm_lifetime_end_p0.Invoke(80L, &printf_core_FormatSection4);
					llvm_lifetime_end_p0.Invoke(4L, &num27);
				}
				llvm_lifetime_end_p0.Invoke(1L, &b2);
				llvm_lifetime_end_p0.Invoke(4L, &num22);
				llvm_lifetime_end_p0.Invoke(4L, &num20);
				llvm_lifetime_end_p0.Invoke(4L, &num19);
				llvm_lifetime_end_p0.Invoke(1L, &b);
				llvm_lifetime_end_p0.Invoke(4L, &num18);
				llvm_lifetime_end_p0.Invoke(4L, &num17);
				llvm_lifetime_end_p0.Invoke(8L, &num16);
				llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view3);
				llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc3);
				llvm_lifetime_end_p0.Invoke(8L, &num15);
				llvm_lifetime_end_p0.Invoke(8L, &num11);
				llvm_lifetime_end_p0.Invoke(8L, &num10);
				llvm_lifetime_end_p0.Invoke(8L, &num9);
				llvm_lifetime_end_p0.Invoke(8L, &num8);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(80L, &printf_core_FormatSection2);
				llvm_memset_p0_i64.Invoke(&printf_core_FormatSection2, -86, 80L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&printf_core_FormatSection2, to_conv, 80L, isVolatile: false);
				if (((byte)to_conv->flags & 8) != 0)
				{
					printf_core_FormatSection2.precision = num3 - 1;
				}
				else
				{
					printf_core_FormatSection2.precision = 0;
				}
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm3, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
				result = int_printf_core_convert_float_decimal_typed_double_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_double.Invoke(writer, &printf_core_FormatSection2, fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val);
				llvm_lifetime_end_p0.Invoke(80L, &printf_core_FormatSection2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num7);
			llvm_lifetime_end_p0.Invoke(4L, &num6);
			llvm_lifetime_end_p0.Invoke(32L, &floatToString_rwjwy);
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(16L, &x);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
