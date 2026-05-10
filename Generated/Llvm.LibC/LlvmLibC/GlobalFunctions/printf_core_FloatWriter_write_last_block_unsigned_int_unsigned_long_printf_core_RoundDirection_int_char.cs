using System;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter16write_last_blockEjmNS0_14RoundDirectionEic")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::write_last_block(unsigned int, unsigned long, __llvm_libc_20_1_2_::printf_core::RoundDirection, int, char)")]
internal static partial class printf_core_FloatWriter_write_last_block_unsigned_int_unsigned_long_printf_core_RoundDirection_int_char
{
	public unsafe static int Invoke(void* @this, int block, long block_digits, int round, int exponent, sbyte exp_char)
	{
		int result = 0;
		sbyte b = 0;
		InlineArray9_SByte inlineArray9_SByte = default(InlineArray9_SByte);
		IntegerToString_uuwdyc integerToString_uuwdyc = default(IntegerToString_uuwdyc);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		long num = 0L;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		int i = 0;
		int j = 0;
		IntegerToString_uuwdyc integerToString_uuwdyc2 = default(IntegerToString_uuwdyc);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		long num2 = 0L;
		long num3 = 0L;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		cpp_string_view cpp_string_view4 = default(cpp_string_view);
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		int num15 = 0;
		long num16 = 0L;
		int num17 = 0;
		int num18 = 0;
		IntegerToString_uuwdyc integerToString_uuwdyc3 = default(IntegerToString_uuwdyc);
		int num19 = 0;
		cpp_string_view cpp_string_view5 = default(cpp_string_view);
		int num20 = exponent;
		sbyte b5 = exp_char;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = ((b5 != 0) ? ((sbyte)1) : ((sbyte)0));
		llvm_lifetime_start_p0.Invoke(9L, &inlineArray9_SByte);
		unchecked
		{
			*(sbyte*)(&inlineArray9_SByte) = -86;
			((sbyte*)(&inlineArray9_SByte))[1] = -86;
			((sbyte*)(&inlineArray9_SByte))[2] = -86;
			((sbyte*)(&inlineArray9_SByte))[3] = -86;
			((sbyte*)(&inlineArray9_SByte))[4] = -86;
			((sbyte*)(&inlineArray9_SByte))[5] = -86;
			((sbyte*)(&inlineArray9_SByte))[6] = -86;
			((sbyte*)(&inlineArray9_SByte))[7] = -86;
			((sbyte*)(&inlineArray9_SByte))[8] = -86;
			llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc);
			sbyte* ptr = (sbyte*)(&integerToString_uuwdyc);
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
			sbyte* ptr2 = (sbyte*)(&integerToString_uuwdyc) + 21;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			((long*)(&integerToString_uuwdyc))[3] = -6148914691236517206L;
			IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerToString_long.Invoke(&integerToString_uuwdyc, (uint)(block + 1000000000));
			llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
			*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
			((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
			Struct_kqhe8i struct_kqhe8i = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view_const.Invoke(&integerToString_uuwdyc);
			cpp_string_view* num21 = &cpp_string_view2;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num21 = struct_kqhe8i2.field_0;
			byte* num22 = (byte*)(&cpp_string_view2) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num22 = struct_kqhe8i3.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < (ulong)block_digits; num++)
			{
				sbyte b6 = *(sbyte*)cpp_string_view_operator_unsigned_long_const.Invoke(&cpp_string_view2, num + 1L + (9L - block_digits));
				Unsafe.As<InlineArray9_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray9_SByte, (nint)num)) = b6;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc);
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = 48;
			if ((ulong)block_digits > 0uL)
			{
				b2 = Unsafe.As<InlineArray9_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray9_SByte, (nint)(block_digits - 1L)));
			}
			else if ((ulong)((printf_core_FloatWriter*)@this)->max_block_count > 0uL)
			{
				b2 = 57;
			}
			else if ((ulong)((printf_core_FloatWriter*)@this)->buffered_digits > 0uL)
			{
				b2 = ((sbyte*)(&((printf_core_FloatWriter*)@this)->block_buffer))[((printf_core_FloatWriter*)@this)->buffered_digits - 1L];
			}
			llvm_lifetime_start_p0.Invoke(1L, &b3);
			b3 = 0;
			int num25;
			if (round == 0 || (round == 2 && b2 % 2 != 0))
			{
				llvm_lifetime_start_p0.Invoke(1L, &b4);
				b4 = 1;
				b3 = 1;
				llvm_lifetime_start_p0.Invoke(4L, &i);
				checked
				{
					for (i = unchecked((int)block_digits) - 1; i >= 0; i += -1)
					{
						if ((b4 & 1) != 1)
						{
							break;
						}
						if (Unsafe.As<InlineArray9_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray9_SByte, i)) == 57)
						{
							Unsafe.As<InlineArray9_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray9_SByte, i)) = 48;
							continue;
						}
						unchecked
						{
							sbyte* ptr3 = (sbyte*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_SByte, i));
							*ptr3 = (sbyte)checked(*ptr3 + 1);
							b4 = 0;
							b3 = 0;
						}
					}
					llvm_lifetime_end_p0.Invoke(4L, &i);
					llvm_lifetime_start_p0.Invoke(4L, &j);
					for (j = unchecked((int)((printf_core_FloatWriter*)@this)->buffered_digits) - 1; j >= 0; j += -1)
					{
						if ((b4 & 1) != 1)
						{
							break;
						}
						unchecked
						{
							if (((sbyte*)(&((printf_core_FloatWriter*)@this)->block_buffer))[j] == 57)
							{
								((sbyte*)(&((printf_core_FloatWriter*)@this)->block_buffer))[j] = 48;
								continue;
							}
							sbyte* ptr4 = (sbyte*)(&((printf_core_FloatWriter*)@this)->block_buffer) + j;
							*ptr4 = (sbyte)checked(*ptr4 + 1);
							b4 = 0;
						}
					}
					llvm_lifetime_end_p0.Invoke(4L, &j);
				}
				if ((b4 & 1) == 1)
				{
					if ((b & 1) == 1)
					{
						num20 = checked(num20 + 1);
						llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc2);
						sbyte* ptr5 = (sbyte*)(&integerToString_uuwdyc2);
						*ptr5 = -86;
						ptr5[1] = -86;
						ptr5[2] = -86;
						ptr5[3] = -86;
						ptr5[4] = -86;
						ptr5[5] = -86;
						ptr5[6] = -86;
						ptr5[7] = -86;
						ptr5[8] = -86;
						ptr5[9] = -86;
						ptr5[10] = -86;
						ptr5[11] = -86;
						ptr5[12] = -86;
						ptr5[13] = -86;
						ptr5[14] = -86;
						ptr5[15] = -86;
						ptr5[16] = -86;
						ptr5[17] = -86;
						ptr5[18] = -86;
						ptr5[19] = -86;
						ptr5[20] = -86;
						sbyte* ptr6 = (sbyte*)(&integerToString_uuwdyc2) + 21;
						*ptr6 = -86;
						ptr6[1] = -86;
						ptr6[2] = -86;
						((long*)(&integerToString_uuwdyc2))[3] = -6148914691236517206L;
						IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_IntegerToString_long.Invoke(&integerToString_uuwdyc2, num20);
						llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view3);
						*(IntPtr*)(&cpp_string_view3) = unchecked((nint)(-6148914691236517206L));
						((long*)(&cpp_string_view3))[1] = -6148914691236517206L;
						Struct_kqhe8i struct_kqhe8i4 = IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_view_const.Invoke(&integerToString_uuwdyc2);
						cpp_string_view* num23 = &cpp_string_view3;
						Struct_kqhe8i struct_kqhe8i5 = struct_kqhe8i4;
						*(void**)num23 = struct_kqhe8i5.field_0;
						byte* num24 = (byte*)(&cpp_string_view3) + 8u;
						Struct_kqhe8i struct_kqhe8i6 = struct_kqhe8i4;
						*(long*)num24 = struct_kqhe8i6.field_1;
						llvm_lifetime_start_p0.Invoke(8L, &num2);
						num2 = cpp_string_view_size_const.Invoke(&cpp_string_view3);
						llvm_lifetime_start_p0.Invoke(8L, &num3);
						num3 = ((printf_core_FloatWriter*)@this)->buffered_digits + ((printf_core_FloatWriter*)@this)->max_block_count * 9L + block_digits;
						((printf_core_FloatWriter*)@this)->total_digits = InstructionHelper.Select((((printf_core_FloatWriter*)@this)->has_decimal_point & 1) == 1, 1, 0) + num3 + 1L + num2;
						llvm_lifetime_start_p0.Invoke(4L, &num4);
						num4 = printf_core_PaddingWriter_write_left_padding_printf_core_Writer_unsigned_long.Invoke(&((printf_core_FloatWriter*)@this)->padding_writer, ((printf_core_FloatWriter*)@this)->writer, ((printf_core_FloatWriter*)@this)->total_digits);
						if (num4 < 0)
						{
							result = num4;
							num25 = 1;
						}
						else
						{
							num25 = 0;
						}
						llvm_lifetime_end_p0.Invoke(4L, &num4);
						switch (num25)
						{
						case 0:
							llvm_lifetime_start_p0.Invoke(4L, &num5);
							num5 = printf_core_Writer_write_char.Invoke(((printf_core_FloatWriter*)@this)->writer, 49);
							if (num5 < 0)
							{
								result = num5;
								num25 = 1;
							}
							else
							{
								num25 = 0;
							}
							llvm_lifetime_end_p0.Invoke(4L, &num5);
							switch (num25)
							{
							case 0:
								{
									if ((((printf_core_FloatWriter*)@this)->has_decimal_point & 1) == 1)
									{
										llvm_lifetime_start_p0.Invoke(4L, &num6);
										num6 = printf_core_Writer_write_char.Invoke(((printf_core_FloatWriter*)@this)->writer, 46);
										if (num6 < 0)
										{
											result = num6;
											num25 = 1;
										}
										else
										{
											num25 = 0;
										}
										llvm_lifetime_end_p0.Invoke(4L, &num6);
										switch (num25)
										{
										case 0:
											break;
										default:
											goto end_IL_07e0;
										}
										if ((ulong)num3 > 1uL)
										{
											llvm_lifetime_start_p0.Invoke(4L, &num7);
											num7 = printf_core_Writer_write_char_unsigned_long.Invoke(((printf_core_FloatWriter*)@this)->writer, 48, num3 - 1L);
											if (num7 < 0)
											{
												result = num7;
												num25 = 1;
											}
											else
											{
												num25 = 0;
											}
											llvm_lifetime_end_p0.Invoke(4L, &num7);
											switch (num25)
											{
											case 0:
												break;
											default:
												goto end_IL_07e0;
											}
										}
									}
									llvm_lifetime_start_p0.Invoke(4L, &num8);
									num8 = printf_core_Writer_write_char.Invoke(((printf_core_FloatWriter*)@this)->writer, b5);
									if (num8 < 0)
									{
										result = num8;
										num25 = 1;
									}
									else
									{
										num25 = 0;
									}
									llvm_lifetime_end_p0.Invoke(4L, &num8);
									switch (num25)
									{
									case 0:
									{
										llvm_lifetime_start_p0.Invoke(4L, &num9);
										void* writer = ((printf_core_FloatWriter*)@this)->writer;
										llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view4, &cpp_string_view3, 16L, isVolatile: false);
										num9 = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view4), ((long*)(&cpp_string_view4))[1]);
										if (num9 < 0)
										{
											result = num9;
											num25 = 1;
										}
										else
										{
											num25 = 0;
										}
										llvm_lifetime_end_p0.Invoke(4L, &num9);
										switch (num25)
										{
										case 0:
											((printf_core_FloatWriter*)@this)->total_digits_written = ((printf_core_FloatWriter*)@this)->total_digits;
											result = 0;
											num25 = 1;
											break;
										}
										break;
									}
									}
									break;
								}
								end_IL_07e0:
								break;
							}
							break;
						}
						llvm_lifetime_end_p0.Invoke(8L, &num3);
						llvm_lifetime_end_p0.Invoke(8L, &num2);
						llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view3);
						llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc2);
					}
					else
					{
						((printf_core_FloatWriter*)@this)->total_digits++;
						((printf_core_FloatWriter*)@this)->digits_before_decimal++;
						llvm_lifetime_start_p0.Invoke(4L, &num10);
						num10 = printf_core_PaddingWriter_write_left_padding_printf_core_Writer_unsigned_long.Invoke(&((printf_core_FloatWriter*)@this)->padding_writer, ((printf_core_FloatWriter*)@this)->writer, ((printf_core_FloatWriter*)@this)->total_digits);
						if (num10 < 0)
						{
							result = num10;
							num25 = 1;
						}
						else
						{
							num25 = 0;
						}
						llvm_lifetime_end_p0.Invoke(4L, &num10);
						switch (num25)
						{
						case 0:
							llvm_lifetime_start_p0.Invoke(4L, &num11);
							num11 = printf_core_Writer_write_char.Invoke(((printf_core_FloatWriter*)@this)->writer, 49);
							if (num11 < 0)
							{
								result = num11;
								num25 = 1;
							}
							else
							{
								num25 = 0;
							}
							llvm_lifetime_end_p0.Invoke(4L, &num11);
							switch (num25)
							{
							case 0:
								llvm_lifetime_start_p0.Invoke(4L, &num12);
								num12 = printf_core_Writer_write_char_unsigned_long.Invoke(((printf_core_FloatWriter*)@this)->writer, 48, ((printf_core_FloatWriter*)@this)->digits_before_decimal - 1L);
								if (num12 < 0)
								{
									result = num12;
									num25 = 1;
								}
								else
								{
									num25 = 0;
								}
								llvm_lifetime_end_p0.Invoke(4L, &num12);
								switch (num25)
								{
								case 0:
									{
										if ((((printf_core_FloatWriter*)@this)->has_decimal_point & 1) == 1)
										{
											llvm_lifetime_start_p0.Invoke(4L, &num13);
											num13 = printf_core_Writer_write_char.Invoke(((printf_core_FloatWriter*)@this)->writer, 46);
											if (num13 < 0)
											{
												result = num13;
												num25 = 1;
											}
											else
											{
												num25 = 0;
											}
											llvm_lifetime_end_p0.Invoke(4L, &num13);
											switch (num25)
											{
											case 0:
												break;
											default:
												goto end_IL_0b44;
											}
											if ((ulong)((printf_core_FloatWriter*)@this)->total_digits > (ulong)(((printf_core_FloatWriter*)@this)->digits_before_decimal + 1L))
											{
												llvm_lifetime_start_p0.Invoke(4L, &num14);
												num14 = printf_core_Writer_write_char_unsigned_long.Invoke(((printf_core_FloatWriter*)@this)->writer, 48, ((printf_core_FloatWriter*)@this)->total_digits - (((printf_core_FloatWriter*)@this)->digits_before_decimal + 1L));
												if (num14 < 0)
												{
													result = num14;
													num25 = 1;
												}
												else
												{
													num25 = 0;
												}
												llvm_lifetime_end_p0.Invoke(4L, &num14);
												switch (num25)
												{
												case 0:
													break;
												default:
													goto end_IL_0b44;
												}
											}
										}
										((printf_core_FloatWriter*)@this)->total_digits_written = ((printf_core_FloatWriter*)@this)->total_digits;
										result = 0;
										num25 = 1;
										break;
									}
									end_IL_0b44:
									break;
								}
								break;
							}
							break;
						}
					}
				}
				else
				{
					num25 = 0;
				}
				llvm_lifetime_end_p0.Invoke(1L, &b4);
				switch (num25)
				{
				case 0:
					break;
				default:
					goto IL_0fd0;
				}
			}
			llvm_lifetime_start_p0.Invoke(4L, &num15);
			num15 = printf_core_FloatWriter_flush_buffer_bool.Invoke(@this, (b3 & 1) == 1);
			if (num15 < 0)
			{
				result = num15;
				num25 = 1;
			}
			else
			{
				num25 = 0;
			}
			llvm_lifetime_end_p0.Invoke(4L, &num15);
			switch (num25)
			{
			case 0:
				llvm_lifetime_start_p0.Invoke(8L, &num16);
				for (num16 = 0L; (ulong)num16 < (ulong)block_digits; num16++)
				{
					sbyte b7 = Unsafe.As<InlineArray9_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray9_SByte, (nint)num16));
					((sbyte*)(&((printf_core_FloatWriter*)@this)->block_buffer))[num16] = b7;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num16);
				((printf_core_FloatWriter*)@this)->buffered_digits = block_digits;
				llvm_lifetime_start_p0.Invoke(4L, &num17);
				num17 = printf_core_FloatWriter_flush_buffer_bool.Invoke(@this, round_up_max_blocks: false);
				if (num17 < 0)
				{
					result = num17;
					num25 = 1;
				}
				else
				{
					num25 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num17);
				switch (num25)
				{
				case 0:
					{
						if ((b & 1) == 1)
						{
							llvm_lifetime_start_p0.Invoke(4L, &num18);
							num18 = printf_core_Writer_write_char.Invoke(((printf_core_FloatWriter*)@this)->writer, b5);
							if (num18 < 0)
							{
								result = num18;
								num25 = 1;
							}
							else
							{
								num25 = 0;
							}
							llvm_lifetime_end_p0.Invoke(4L, &num18);
							switch (num25)
							{
							case 0:
								break;
							default:
								goto end_IL_0d99;
							}
							llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc3);
							sbyte* ptr7 = (sbyte*)(&integerToString_uuwdyc3);
							*ptr7 = -86;
							ptr7[1] = -86;
							ptr7[2] = -86;
							ptr7[3] = -86;
							ptr7[4] = -86;
							ptr7[5] = -86;
							ptr7[6] = -86;
							ptr7[7] = -86;
							ptr7[8] = -86;
							ptr7[9] = -86;
							ptr7[10] = -86;
							ptr7[11] = -86;
							ptr7[12] = -86;
							ptr7[13] = -86;
							ptr7[14] = -86;
							ptr7[15] = -86;
							ptr7[16] = -86;
							ptr7[17] = -86;
							ptr7[18] = -86;
							ptr7[19] = -86;
							ptr7[20] = -86;
							sbyte* ptr8 = (sbyte*)(&integerToString_uuwdyc3) + 21;
							*ptr8 = -86;
							ptr8[1] = -86;
							ptr8[2] = -86;
							((long*)(&integerToString_uuwdyc3))[3] = -6148914691236517206L;
							IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_IntegerToString_long.Invoke(&integerToString_uuwdyc3, num20);
							llvm_lifetime_start_p0.Invoke(4L, &num19);
							void* writer2 = ((printf_core_FloatWriter*)@this)->writer;
							Struct_kqhe8i struct_kqhe8i7 = IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_view_const.Invoke(&integerToString_uuwdyc3);
							cpp_string_view* num26 = &cpp_string_view5;
							Struct_kqhe8i struct_kqhe8i8 = struct_kqhe8i7;
							*(void**)num26 = struct_kqhe8i8.field_0;
							byte* num27 = (byte*)(&cpp_string_view5) + 8u;
							Struct_kqhe8i struct_kqhe8i9 = struct_kqhe8i7;
							*(long*)num27 = struct_kqhe8i9.field_1;
							num19 = printf_core_Writer_write_cpp_string_view.Invoke(writer2, *(void**)(&cpp_string_view5), ((long*)(&cpp_string_view5))[1]);
							if (num19 < 0)
							{
								result = num19;
								num25 = 1;
							}
							else
							{
								num25 = 0;
							}
							llvm_lifetime_end_p0.Invoke(4L, &num19);
							switch (num25)
							{
							case 0:
								num25 = 0;
								break;
							}
							llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc3);
							switch (num25)
							{
							case 0:
								break;
							default:
								goto end_IL_0d99;
							}
						}
						((printf_core_FloatWriter*)@this)->total_digits_written = ((printf_core_FloatWriter*)@this)->total_digits;
						result = 0;
						break;
					}
					end_IL_0d99:
					break;
				}
				break;
			}
			goto IL_0fd0;
		}
		IL_0fd0:
		llvm_lifetime_end_p0.Invoke(1L, &b3);
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(9L, &inlineArray9_SByte);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
	}
}
