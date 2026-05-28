using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatWriter_write_last_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter16write_last_blockEjmNS0_14RoundDirectionEic")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::write_last_block(unsigned int, unsigned long, __llvm_libc_20_1_2_::printf_core::RoundDirection, int, char)")]
	public unsafe static int Invoke([MangledName("this")] Printf_core_FloatWriter* This, [MangledName("block")][NativeType("unsigned int")] int Block, [MangledName("block_digits")][NativeType("unsigned long")] long Block_digits, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::printf_core::RoundDirection")] RoundDirection_zvveyk Round, [MangledName("exponent")][NativeType("int")] int Exponent, [MangledName("exp_char")][NativeType("char")] sbyte Exp_char)
	{
		int result = 0;
		sbyte b = 0;
		InlineArray9_SByte inlineArray9_SByte = default(InlineArray9_SByte);
		IntegerToString_uuwdyc integerToString_uuwdyc = default(IntegerToString_uuwdyc);
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		long num = 0L;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		int i = 0;
		int j = 0;
		IntegerToString_uuwdyc integerToString_uuwdyc2 = default(IntegerToString_uuwdyc);
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		long num2 = 0L;
		long num3 = 0L;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		Cpp_string_view cpp_string_view3 = default(Cpp_string_view);
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
		Cpp_string_view cpp_string_view4 = default(Cpp_string_view);
		int num20 = Exponent;
		sbyte b5 = Exp_char;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = ((b5 != 0) ? ((sbyte)1) : ((sbyte)0));
		Llvm_lifetime_start_p0.Invoke(9L, &inlineArray9_SByte);
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
			Llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc);
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
			IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&integerToString_uuwdyc, (uint)(Block + 1000000000));
			Llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view);
			*(IntPtr*)(&cpp_string_view) = unchecked((nint)(-6148914691236517206L));
			((long*)(&cpp_string_view))[1] = -6148914691236517206L;
			Struct_kqhe8i struct_kqhe8i = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view.Invoke(&integerToString_uuwdyc);
			Cpp_string_view* num21 = &cpp_string_view;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num21 = struct_kqhe8i2.field_0;
			byte* num22 = (byte*)(&cpp_string_view) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num22 = struct_kqhe8i3.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < (ulong)Block_digits; num++)
			{
				sbyte b6 = *(sbyte*)String_view_Index.Invoke(&cpp_string_view, num + 1L + (9L - Block_digits));
				Unsafe.As<InlineArray9_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray9_SByte, (nint)num)) = b6;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view);
			Llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc);
			Llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = 48;
			if ((ulong)Block_digits > 0uL)
			{
				b2 = Unsafe.As<InlineArray9_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray9_SByte, (nint)(Block_digits - 1L)));
			}
			else if ((ulong)This->Max_block_count > 0uL)
			{
				b2 = 57;
			}
			else if ((ulong)This->Buffered_digits > 0uL)
			{
				b2 = ((sbyte*)(&This->Block_buffer))[This->Buffered_digits - 1L];
			}
			Llvm_lifetime_start_p0.Invoke(1L, &b3);
			b3 = 0;
			int num25;
			if (Round == RoundDirection_zvveyk.Up || (Round == RoundDirection_zvveyk.Even && b2 % 2 != 0))
			{
				Llvm_lifetime_start_p0.Invoke(1L, &b4);
				b4 = 1;
				b3 = 1;
				Llvm_lifetime_start_p0.Invoke(4L, &i);
				checked
				{
					for (i = unchecked((int)Block_digits) - 1; i >= 0; i += -1)
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
					Llvm_lifetime_end_p0.Invoke(4L, &i);
					Llvm_lifetime_start_p0.Invoke(4L, &j);
					for (j = unchecked((int)This->Buffered_digits) - 1; j >= 0; j += -1)
					{
						if ((b4 & 1) != 1)
						{
							break;
						}
						unchecked
						{
							if (((sbyte*)(&This->Block_buffer))[j] == 57)
							{
								((sbyte*)(&This->Block_buffer))[j] = 48;
								continue;
							}
							sbyte* ptr4 = (sbyte*)(&This->Block_buffer) + j;
							*ptr4 = (sbyte)checked(*ptr4 + 1);
							b4 = 0;
						}
					}
					Llvm_lifetime_end_p0.Invoke(4L, &j);
				}
				if ((b4 & 1) == 1)
				{
					if ((b & 1) == 1)
					{
						num20 = checked(num20 + 1);
						Llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc2);
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
						IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_Constructor.Invoke(&integerToString_uuwdyc2, num20);
						Llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
						*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
						((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
						Struct_kqhe8i struct_kqhe8i4 = IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_view.Invoke(&integerToString_uuwdyc2);
						Cpp_string_view* num23 = &cpp_string_view2;
						Struct_kqhe8i struct_kqhe8i5 = struct_kqhe8i4;
						*(void**)num23 = struct_kqhe8i5.field_0;
						byte* num24 = (byte*)(&cpp_string_view2) + 8u;
						Struct_kqhe8i struct_kqhe8i6 = struct_kqhe8i4;
						*(long*)num24 = struct_kqhe8i6.field_1;
						Llvm_lifetime_start_p0.Invoke(8L, &num2);
						num2 = String_view_size.Invoke(&cpp_string_view2);
						Llvm_lifetime_start_p0.Invoke(8L, &num3);
						num3 = This->Buffered_digits + This->Max_block_count * 9L + Block_digits;
						This->Total_digits = InstructionHelper.Select((This->Has_decimal_point & 1) == 1, 1, 0) + num3 + 1L + num2;
						Llvm_lifetime_start_p0.Invoke(4L, &num4);
						num4 = PaddingWriter_write_left_padding.Invoke(&This->Padding_writer, This->Writer, This->Total_digits);
						if (num4 < 0)
						{
							result = num4;
							num25 = 1;
						}
						else
						{
							num25 = 0;
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num4);
						switch (num25)
						{
						case 0:
							Llvm_lifetime_start_p0.Invoke(4L, &num5);
							num5 = Writer_write.Invoke(This->Writer, 49);
							if (num5 < 0)
							{
								result = num5;
								num25 = 1;
							}
							else
							{
								num25 = 0;
							}
							Llvm_lifetime_end_p0.Invoke(4L, &num5);
							switch (num25)
							{
							case 0:
								{
									if ((This->Has_decimal_point & 1) == 1)
									{
										Llvm_lifetime_start_p0.Invoke(4L, &num6);
										num6 = Writer_write.Invoke(This->Writer, 46);
										if (num6 < 0)
										{
											result = num6;
											num25 = 1;
										}
										else
										{
											num25 = 0;
										}
										Llvm_lifetime_end_p0.Invoke(4L, &num6);
										switch (num25)
										{
										case 0:
											break;
										default:
											goto end_IL_07e0;
										}
										if ((ulong)num3 > 1uL)
										{
											Llvm_lifetime_start_p0.Invoke(4L, &num7);
											num7 = Writer_write.Invoke(This->Writer, 48, num3 - 1L);
											if (num7 < 0)
											{
												result = num7;
												num25 = 1;
											}
											else
											{
												num25 = 0;
											}
											Llvm_lifetime_end_p0.Invoke(4L, &num7);
											switch (num25)
											{
											case 0:
												break;
											default:
												goto end_IL_07e0;
											}
										}
									}
									Llvm_lifetime_start_p0.Invoke(4L, &num8);
									num8 = Writer_write.Invoke(This->Writer, b5);
									if (num8 < 0)
									{
										result = num8;
										num25 = 1;
									}
									else
									{
										num25 = 0;
									}
									Llvm_lifetime_end_p0.Invoke(4L, &num8);
									switch (num25)
									{
									case 0:
									{
										Llvm_lifetime_start_p0.Invoke(4L, &num9);
										Printf_core_Writer* writer = This->Writer;
										Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &cpp_string_view2, 16L, isVolatile: false);
										num9 = Writer_write.Invoke(writer, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
										if (num9 < 0)
										{
											result = num9;
											num25 = 1;
										}
										else
										{
											num25 = 0;
										}
										Llvm_lifetime_end_p0.Invoke(4L, &num9);
										switch (num25)
										{
										case 0:
											This->Total_digits_written = This->Total_digits;
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
						Llvm_lifetime_end_p0.Invoke(8L, &num3);
						Llvm_lifetime_end_p0.Invoke(8L, &num2);
						Llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
						Llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc2);
					}
					else
					{
						This->Total_digits++;
						This->Digits_before_decimal++;
						Llvm_lifetime_start_p0.Invoke(4L, &num10);
						num10 = PaddingWriter_write_left_padding.Invoke(&This->Padding_writer, This->Writer, This->Total_digits);
						if (num10 < 0)
						{
							result = num10;
							num25 = 1;
						}
						else
						{
							num25 = 0;
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num10);
						switch (num25)
						{
						case 0:
							Llvm_lifetime_start_p0.Invoke(4L, &num11);
							num11 = Writer_write.Invoke(This->Writer, 49);
							if (num11 < 0)
							{
								result = num11;
								num25 = 1;
							}
							else
							{
								num25 = 0;
							}
							Llvm_lifetime_end_p0.Invoke(4L, &num11);
							switch (num25)
							{
							case 0:
								Llvm_lifetime_start_p0.Invoke(4L, &num12);
								num12 = Writer_write.Invoke(This->Writer, 48, This->Digits_before_decimal - 1L);
								if (num12 < 0)
								{
									result = num12;
									num25 = 1;
								}
								else
								{
									num25 = 0;
								}
								Llvm_lifetime_end_p0.Invoke(4L, &num12);
								switch (num25)
								{
								case 0:
									{
										if ((This->Has_decimal_point & 1) == 1)
										{
											Llvm_lifetime_start_p0.Invoke(4L, &num13);
											num13 = Writer_write.Invoke(This->Writer, 46);
											if (num13 < 0)
											{
												result = num13;
												num25 = 1;
											}
											else
											{
												num25 = 0;
											}
											Llvm_lifetime_end_p0.Invoke(4L, &num13);
											switch (num25)
											{
											case 0:
												break;
											default:
												goto end_IL_0b44;
											}
											if ((ulong)This->Total_digits > (ulong)(This->Digits_before_decimal + 1L))
											{
												Llvm_lifetime_start_p0.Invoke(4L, &num14);
												num14 = Writer_write.Invoke(This->Writer, 48, This->Total_digits - (This->Digits_before_decimal + 1L));
												if (num14 < 0)
												{
													result = num14;
													num25 = 1;
												}
												else
												{
													num25 = 0;
												}
												Llvm_lifetime_end_p0.Invoke(4L, &num14);
												switch (num25)
												{
												case 0:
													break;
												default:
													goto end_IL_0b44;
												}
											}
										}
										This->Total_digits_written = This->Total_digits;
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
				Llvm_lifetime_end_p0.Invoke(1L, &b4);
				switch (num25)
				{
				case 0:
					break;
				default:
					goto IL_0fd0;
				}
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num15);
			num15 = FloatWriter_flush_buffer.Invoke(This, (b3 & 1) == 1);
			if (num15 < 0)
			{
				result = num15;
				num25 = 1;
			}
			else
			{
				num25 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num15);
			switch (num25)
			{
			case 0:
				Llvm_lifetime_start_p0.Invoke(8L, &num16);
				for (num16 = 0L; (ulong)num16 < (ulong)Block_digits; num16++)
				{
					sbyte b7 = Unsafe.As<InlineArray9_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray9_SByte, (nint)num16));
					((sbyte*)(&This->Block_buffer))[num16] = b7;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num16);
				This->Buffered_digits = Block_digits;
				Llvm_lifetime_start_p0.Invoke(4L, &num17);
				num17 = FloatWriter_flush_buffer.Invoke(This, Round_up_max_blocks: false);
				if (num17 < 0)
				{
					result = num17;
					num25 = 1;
				}
				else
				{
					num25 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num17);
				switch (num25)
				{
				case 0:
					{
						if ((b & 1) == 1)
						{
							Llvm_lifetime_start_p0.Invoke(4L, &num18);
							num18 = Writer_write.Invoke(This->Writer, b5);
							if (num18 < 0)
							{
								result = num18;
								num25 = 1;
							}
							else
							{
								num25 = 0;
							}
							Llvm_lifetime_end_p0.Invoke(4L, &num18);
							switch (num25)
							{
							case 0:
								break;
							default:
								goto end_IL_0d99;
							}
							Llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc3);
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
							IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_Constructor.Invoke(&integerToString_uuwdyc3, num20);
							Llvm_lifetime_start_p0.Invoke(4L, &num19);
							Printf_core_Writer* writer2 = This->Writer;
							Struct_kqhe8i struct_kqhe8i7 = IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_view.Invoke(&integerToString_uuwdyc3);
							Cpp_string_view* num26 = &cpp_string_view4;
							Struct_kqhe8i struct_kqhe8i8 = struct_kqhe8i7;
							*(void**)num26 = struct_kqhe8i8.field_0;
							byte* num27 = (byte*)(&cpp_string_view4) + 8u;
							Struct_kqhe8i struct_kqhe8i9 = struct_kqhe8i7;
							*(long*)num27 = struct_kqhe8i9.field_1;
							num19 = Writer_write.Invoke(writer2, *(void**)(&cpp_string_view4), ((long*)(&cpp_string_view4))[1]);
							if (num19 < 0)
							{
								result = num19;
								num25 = 1;
							}
							else
							{
								num25 = 0;
							}
							Llvm_lifetime_end_p0.Invoke(4L, &num19);
							switch (num25)
							{
							case 0:
								num25 = 0;
								break;
							}
							Llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc3);
							switch (num25)
							{
							case 0:
								break;
							default:
								goto end_IL_0d99;
							}
						}
						This->Total_digits_written = This->Total_digits;
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
		Llvm_lifetime_end_p0.Invoke(1L, &b3);
		Llvm_lifetime_end_p0.Invoke(1L, &b2);
		Llvm_lifetime_end_p0.Invoke(9L, &inlineArray9_SByte);
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
	}
}
