using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_convert_float_dec_auto_typed_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core28convert_float_dec_auto_typedIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiPNS0_6WriterERKNS0_13FormatSectionENS_6fputil6FPBitsIS4_EE")]
	[DemangledName("int __llvm_libc_20_1_2_::printf_core::convert_float_dec_auto_typed<double, 0>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&, __llvm_libc_20_1_2_::fputil::FPBits<double>)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("writer")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Llvm_libc_20_1_2_printf_core_Writer* Writer, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection const&")] Llvm_libc_20_1_2_printf_core_FormatSection* To_conv, [MangledName("float_bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<double>")] long Float_bits)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		int num = 0;
		int num2 = 0;
		Int128 x = default(Int128);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		Llvm_libc_20_1_2_FloatToString_rwjwy3 llvm_libc_20_1_2_FloatToString_rwjwy = default(Llvm_libc_20_1_2_FloatToString_rwjwy3);
		int num6 = 0;
		int num7 = 0;
		Llvm_libc_20_1_2_printf_core_FormatSection llvm_libc_20_1_2_printf_core_FormatSection = default(Llvm_libc_20_1_2_printf_core_FormatSection);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long num8 = 0L;
		Llvm_libc_20_1_2_IntegerToString_uuwdyc llvm_libc_20_1_2_IntegerToString_uuwdyc = default(Llvm_libc_20_1_2_IntegerToString_uuwdyc);
		long num9 = 0L;
		long num10 = 0L;
		long num11 = 0L;
		Llvm_libc_20_1_2_IntegerToString_uuwdyc llvm_libc_20_1_2_IntegerToString_uuwdyc2 = default(Llvm_libc_20_1_2_IntegerToString_uuwdyc);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		long num12 = 0L;
		int num13 = 0;
		int num14 = 0;
		long num15 = 0L;
		Llvm_libc_20_1_2_IntegerToString_uuwdyc llvm_libc_20_1_2_IntegerToString_uuwdyc3 = default(Llvm_libc_20_1_2_IntegerToString_uuwdyc);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view2 = default(Llvm_libc_20_1_2_cpp_string_view);
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
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		sbyte b2 = 0;
		int num24 = 0;
		Llvm_libc_20_1_2_printf_core_FormatSection llvm_libc_20_1_2_printf_core_FormatSection2 = default(Llvm_libc_20_1_2_printf_core_FormatSection);
		int num25 = 0;
		int num26 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		int num27 = 0;
		Llvm_libc_20_1_2_printf_core_FormatSection llvm_libc_20_1_2_printf_core_FormatSection3 = default(Llvm_libc_20_1_2_printf_core_FormatSection);
		int num28 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm4 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = Float_bits;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 52;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		unchecked
		{
			num2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_explicit_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(16L, &x);
			x = (Int128)(UInt128)(ulong)FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = ((To_conv->Precision > 0) ? To_conv->Precision : InstructionHelper.Select(To_conv->Precision == 0, 1, 6));
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = 0;
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = num3 - 1;
			Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_FloatToString_rwjwy);
			*(long*)(&llvm_libc_20_1_2_FloatToString_rwjwy) = -6148914691236517206L;
			((int*)(&llvm_libc_20_1_2_FloatToString_rwjwy))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_FloatToString_rwjwy) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			*(Int128*)((byte*)(&llvm_libc_20_1_2_FloatToString_rwjwy) + 16) = -6148914691236517206L;
			FloatToString_double_0_Constructor.Invoke(&llvm_libc_20_1_2_FloatToString_rwjwy, FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = -1431655766;
			num6 = (int)((num2 >= 0) ? FloatToString_double_0_get_positive_blocks.Invoke(&llvm_libc_20_1_2_FloatToString_rwjwy) : checked(-unchecked((int)FloatToString_double_0_zero_blocks_after_point.Invoke(&llvm_libc_20_1_2_FloatToString_rwjwy))));
			Llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = 0;
			int result;
			if (NumericHelper.IntCmpNe(x, 0L))
			{
				while (num7 == 0)
				{
					num6 = checked(num6 + -1);
					num7 = FloatToString_double_0_get_block.Invoke(&llvm_libc_20_1_2_FloatToString_rwjwy, num6);
				}
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc);
				IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc, (uint)num7);
				long num29 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc);
				num8 = num29;
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
					Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc2);
					sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_IntegerToString_uuwdyc2);
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
					sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_IntegerToString_uuwdyc2) + 21;
					*ptr3 = -86;
					ptr3[1] = -86;
					ptr3[2] = -86;
					((long*)(&llvm_libc_20_1_2_IntegerToString_uuwdyc2))[3] = -6148914691236517206L;
					IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc2, (uint)num7);
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
					*(IntPtr*)(&llvm_libc_20_1_2_cpp_string_view) = unchecked((nint)(-6148914691236517206L));
					((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = -6148914691236517206L;
					Struct_kqhe8i struct_kqhe8i = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc2);
					Llvm_libc_20_1_2_cpp_string_view* num30 = &llvm_libc_20_1_2_cpp_string_view;
					Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
					*(void**)num30 = struct_kqhe8i2.field_0;
					byte* num31 = (byte*)(&llvm_libc_20_1_2_cpp_string_view) + 8u;
					Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
					*(long*)num31 = struct_kqhe8i3.field_1;
					Llvm_lifetime_start_p0.Invoke(8L, &num12);
					for (num12 = 0L; (ulong)num12 < (ulong)num8; num12++)
					{
						if (*(sbyte*)String_view_Index.Invoke(&llvm_libc_20_1_2_cpp_string_view, num12) == 57)
						{
							num11++;
							num10 = 0L;
						}
						else if (*(sbyte*)String_view_Index.Invoke(&llvm_libc_20_1_2_cpp_string_view, num12) == 48)
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
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
					Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc2);
				}
				while ((ulong)(num9 + 9L) < (ulong)(uint)(num5 + 1))
				{
					num7 = FloatToString_double_0_get_block.Invoke(&llvm_libc_20_1_2_FloatToString_rwjwy, num6);
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
						Llvm_lifetime_end_p0.Invoke(4L, &num14);
						Llvm_lifetime_end_p0.Invoke(4L, &num13);
						break;
					}
					num6 = checked(num6 + -1);
				}
				num7 = FloatToString_double_0_get_block.Invoke(&llvm_libc_20_1_2_FloatToString_rwjwy, num6);
				Llvm_lifetime_start_p0.Invoke(8L, &num15);
				num15 = 9L;
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc3);
				sbyte* ptr4 = (sbyte*)(&llvm_libc_20_1_2_IntegerToString_uuwdyc3);
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
				sbyte* ptr5 = (sbyte*)(&llvm_libc_20_1_2_IntegerToString_uuwdyc3) + 21;
				*ptr5 = -86;
				ptr5[1] = -86;
				ptr5[2] = -86;
				((long*)(&llvm_libc_20_1_2_IntegerToString_uuwdyc3))[3] = -6148914691236517206L;
				IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc3, (uint)num7);
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view2);
				*(IntPtr*)(&llvm_libc_20_1_2_cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
				((long*)(&llvm_libc_20_1_2_cpp_string_view2))[1] = -6148914691236517206L;
				Struct_kqhe8i struct_kqhe8i4 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc3);
				Llvm_libc_20_1_2_cpp_string_view* num32 = &llvm_libc_20_1_2_cpp_string_view2;
				Struct_kqhe8i struct_kqhe8i5 = struct_kqhe8i4;
				*(void**)num32 = struct_kqhe8i5.field_0;
				byte* num33 = (byte*)(&llvm_libc_20_1_2_cpp_string_view2) + 8u;
				Struct_kqhe8i struct_kqhe8i6 = struct_kqhe8i4;
				*(long*)num33 = struct_kqhe8i6.field_1;
				Llvm_lifetime_start_p0.Invoke(8L, &num16);
				num16 = 9L - String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view2);
				if (num9 == 0L)
				{
					num15 = String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view2);
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
					if (*(sbyte*)String_view_Index.Invoke(&llvm_libc_20_1_2_cpp_string_view2, i) == 57)
					{
						num11++;
						num10 = 0L;
					}
					else if (*(sbyte*)String_view_Index.Invoke(&llvm_libc_20_1_2_cpp_string_view2, i) == 48)
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
					num21 = FloatToString_double_0_get_block.Invoke(&llvm_libc_20_1_2_FloatToString_rwjwy, num6);
					num20 = (int)((uint)num21 / 100000000u);
					if ((uint)num21 % 100000000u != 0)
					{
						b = 1;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num21);
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num22);
				num22 = -1431655766;
				if ((b & 1) != 1)
				{
					checked
					{
						if (num6 >= 0)
						{
							Llvm_lifetime_start_p0.Invoke(4L, &k);
							for (k = num6 - 1; k >= 0; k += -1)
							{
								Llvm_lifetime_start_p0.Invoke(4L, &num23);
								num23 = FloatToString_double_0_get_block.Invoke(&llvm_libc_20_1_2_FloatToString_rwjwy, k);
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
								Llvm_lifetime_end_p0.Invoke(4L, &num23);
								switch (num34)
								{
								case 0:
									continue;
								}
								break;
							}
							Llvm_lifetime_end_p0.Invoke(4L, &k);
						}
					}
					if ((b & 1) != 1 && checked(num2 - 52) < 0)
					{
						b = (sbyte)(byte)((Printf_core_zero_after_digits_unsigned_long.Invoke(checked(num2 - 52), num5 - num4, FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)), 52) ? 1 : 0) ^ -1);
					}
				}
				int last_digit = num20;
				bool truncated = (b & 1) == 1;
				anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
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
					Llvm_lifetime_start_p0.Invoke(80L, &llvm_libc_20_1_2_printf_core_FormatSection2);
					Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_FormatSection2, -86, 80L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_FormatSection2, To_conv, 80L, isVolatile: false);
					Llvm_lifetime_start_p0.Invoke(4L, &num25);
					num25 = num3 - checked(num4 + 1);
					if (((byte)To_conv->Flags & 8) != 0)
					{
						llvm_libc_20_1_2_printf_core_FormatSection2.Precision = num25;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num26);
						num26 = (int)(num9 - checked(num4 + 1) - num10);
						if (num26 < 0)
						{
							num26 = 0;
						}
						llvm_libc_20_1_2_printf_core_FormatSection2.Precision = ((num26 <= num25) ? num26 : num25);
						Llvm_lifetime_end_p0.Invoke(4L, &num26);
					}
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm, 8L, isVolatile: false);
					result = Printf_core_convert_float_decimal_typed_double_0.Invoke(Writer, &llvm_libc_20_1_2_printf_core_FormatSection2, llvm_libc_20_1_2_fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val);
					Llvm_lifetime_end_p0.Invoke(4L, &num25);
					Llvm_lifetime_end_p0.Invoke(80L, &llvm_libc_20_1_2_printf_core_FormatSection2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num27);
					num27 = num3 - 1;
					Llvm_lifetime_start_p0.Invoke(80L, &llvm_libc_20_1_2_printf_core_FormatSection3);
					Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_FormatSection3, -86, 80L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_FormatSection3, To_conv, 80L, isVolatile: false);
					if (((byte)To_conv->Flags & 8) != 0)
					{
						llvm_libc_20_1_2_printf_core_FormatSection3.Precision = num27;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num28);
						num28 = (int)(num9 - 1L - num10);
						if (num28 < 0)
						{
							num28 = 0;
						}
						llvm_libc_20_1_2_printf_core_FormatSection3.Precision = ((num28 <= num27) ? num28 : num27);
						Llvm_lifetime_end_p0.Invoke(4L, &num28);
					}
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm, 8L, isVolatile: false);
					result = Printf_core_convert_float_dec_exp_typed_double_0.Invoke(Writer, &llvm_libc_20_1_2_printf_core_FormatSection3, llvm_libc_20_1_2_fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val);
					Llvm_lifetime_end_p0.Invoke(80L, &llvm_libc_20_1_2_printf_core_FormatSection3);
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
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view2);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc3);
				Llvm_lifetime_end_p0.Invoke(8L, &num15);
				Llvm_lifetime_end_p0.Invoke(8L, &num11);
				Llvm_lifetime_end_p0.Invoke(8L, &num10);
				Llvm_lifetime_end_p0.Invoke(8L, &num9);
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(80L, &llvm_libc_20_1_2_printf_core_FormatSection);
				Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_FormatSection, -86, 80L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_FormatSection, To_conv, 80L, isVolatile: false);
				if (((byte)To_conv->Flags & 8) != 0)
				{
					llvm_libc_20_1_2_printf_core_FormatSection.Precision = num3 - 1;
				}
				else
				{
					llvm_libc_20_1_2_printf_core_FormatSection.Precision = 0;
				}
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm, 8L, isVolatile: false);
				result = Printf_core_convert_float_decimal_typed_double_0.Invoke(Writer, &llvm_libc_20_1_2_printf_core_FormatSection, llvm_libc_20_1_2_fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val);
				Llvm_lifetime_end_p0.Invoke(80L, &llvm_libc_20_1_2_printf_core_FormatSection);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num7);
			Llvm_lifetime_end_p0.Invoke(4L, &num6);
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_FloatToString_rwjwy);
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
