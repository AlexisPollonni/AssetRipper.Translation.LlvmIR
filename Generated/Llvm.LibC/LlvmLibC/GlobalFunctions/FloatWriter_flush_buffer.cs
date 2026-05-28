using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatWriter_flush_buffer
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter12flush_bufferEb")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::flush_buffer(bool)")]
	public unsafe static int Invoke([MangledName("this")] Printf_core_FloatWriter* This, [MangledName("round_up_max_blocks")][NativeType("bool")] bool Round_up_max_blocks)
	{
		int result = 0;
		sbyte new_char = 0;
		int num = 0;
		long num2 = 0L;
		int num3 = 0;
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		int num4 = 0;
		int num5 = 0;
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		int num6 = 0;
		Cpp_string_view cpp_string_view3 = default(Cpp_string_view);
		long num7 = 0L;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		sbyte b = (Round_up_max_blocks ? ((sbyte)1) : ((sbyte)0));
		Llvm_lifetime_start_p0.Invoke(1L, &new_char);
		new_char = InstructionHelper.Select((b & 1) == 1, (sbyte)48, (sbyte)57);
		int num12;
		if ((This->Has_written & 1) != 1)
		{
			This->Has_written = 1;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = PaddingWriter_write_left_padding.Invoke(&This->Padding_writer, This->Writer, This->Total_digits);
			if (num < 0)
			{
				result = num;
				num12 = 1;
			}
			else
			{
				num12 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			switch (num12)
			{
			case 0:
				break;
			default:
				goto IL_06d3;
			}
		}
		unchecked
		{
			if ((ulong)This->Total_digits_written >= (ulong)This->Digits_before_decimal || (ulong)(This->Total_digits_written + This->Buffered_digits) < (ulong)This->Digits_before_decimal || (This->Has_decimal_point & 1) != 1)
			{
				goto IL_0325;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = This->Digits_before_decimal - This->Total_digits_written;
			if ((ulong)num2 > 0uL)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				Printf_core_Writer* writer = This->Writer;
				String_view_Constructor.Invoke(&cpp_string_view, &This->Block_buffer, num2);
				num3 = Writer_write.Invoke(writer, *(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]);
				if (num3 < 0)
				{
					result = num3;
					num12 = 1;
				}
				else
				{
					num12 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				switch (num12)
				{
				case 0:
					break;
				default:
					goto IL_0304;
				}
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = Writer_write.Invoke(This->Writer, 46);
			if (num4 < 0)
			{
				result = num4;
				num12 = 1;
			}
			else
			{
				num12 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			switch (num12)
			{
			case 0:
				{
					if ((ulong)(This->Buffered_digits - num2) > 0uL)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num5);
						Printf_core_Writer* writer2 = This->Writer;
						String_view_Constructor.Invoke(&cpp_string_view2, (byte*)(&This->Block_buffer) + num2, This->Buffered_digits - num2);
						num5 = Writer_write.Invoke(writer2, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
						if (num5 < 0)
						{
							result = num5;
							num12 = 1;
						}
						else
						{
							num12 = 0;
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num5);
						switch (num12)
						{
						case 0:
							break;
						default:
							goto end_IL_0221;
						}
					}
					long num13 = This->Buffered_digits + 1L;
					This->Total_digits_written += num13;
					This->Buffered_digits = 0L;
					num12 = 0;
					break;
				}
				end_IL_0221:
				break;
			}
			goto IL_0304;
		}
		IL_0325:
		unchecked
		{
			if ((ulong)This->Buffered_digits > 0uL)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num6);
				Printf_core_Writer* writer3 = This->Writer;
				String_view_Constructor.Invoke(&cpp_string_view3, &This->Block_buffer, This->Buffered_digits);
				num6 = Writer_write.Invoke(writer3, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
				if (num6 < 0)
				{
					result = num6;
					num12 = 1;
				}
				else
				{
					num12 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num6);
				switch (num12)
				{
				case 0:
					break;
				default:
					goto IL_06d3;
				}
				long buffered_digits = This->Buffered_digits;
				This->Total_digits_written += buffered_digits;
				This->Buffered_digits = 0L;
			}
			if ((ulong)This->Total_digits_written >= (ulong)This->Digits_before_decimal || (ulong)(This->Total_digits_written + 9L * This->Max_block_count) < (ulong)This->Digits_before_decimal || (This->Has_decimal_point & 1) != 1)
			{
				goto IL_0619;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = This->Digits_before_decimal - This->Total_digits_written;
			if ((ulong)num7 > 0uL)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num8);
				num8 = Writer_write.Invoke(This->Writer, new_char, num7);
				if (num8 < 0)
				{
					result = num8;
					num12 = 1;
				}
				else
				{
					num12 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num8);
				switch (num12)
				{
				case 0:
					break;
				default:
					goto IL_05f8;
				}
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num9);
			num9 = Writer_write.Invoke(This->Writer, 46);
			if (num9 < 0)
			{
				result = num9;
				num12 = 1;
			}
			else
			{
				num12 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num9);
			switch (num12)
			{
			case 0:
				{
					if ((ulong)(9L * This->Max_block_count - num7) > 0uL)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num10);
						num10 = Writer_write.Invoke(This->Writer, new_char, 9L * This->Max_block_count - num7);
						if (num10 < 0)
						{
							result = num10;
							num12 = 1;
						}
						else
						{
							num12 = 0;
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num10);
						switch (num12)
						{
						case 0:
							break;
						default:
							goto end_IL_050f;
						}
					}
					long max_block_count = This->Max_block_count;
					This->Total_digits_written += 9L * max_block_count + 1L;
					This->Max_block_count = 0L;
					num12 = 0;
					break;
				}
				end_IL_050f:
				break;
			}
			goto IL_05f8;
		}
		IL_0619:
		unchecked
		{
			if ((ulong)This->Max_block_count > 0uL)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num11);
				num11 = Writer_write.Invoke(This->Writer, new_char, This->Max_block_count * 9L);
				if (num11 < 0)
				{
					result = num11;
					num12 = 1;
				}
				else
				{
					num12 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num11);
				switch (num12)
				{
				case 0:
					break;
				default:
					goto IL_06d3;
				}
				long num14 = This->Max_block_count * 9L;
				This->Total_digits_written += num14;
				This->Max_block_count = 0L;
			}
			result = 0;
			goto IL_06d3;
		}
		IL_05f8:
		Llvm_lifetime_end_p0.Invoke(8L, &num7);
		switch (num12)
		{
		case 0:
			break;
		default:
			goto IL_06d3;
		}
		goto IL_0619;
		IL_06d3:
		Llvm_lifetime_end_p0.Invoke(1L, &new_char);
		return result;
		IL_0304:
		Llvm_lifetime_end_p0.Invoke(8L, &num2);
		switch (num12)
		{
		case 0:
			break;
		default:
			goto IL_06d3;
		}
		goto IL_0325;
	}
}
