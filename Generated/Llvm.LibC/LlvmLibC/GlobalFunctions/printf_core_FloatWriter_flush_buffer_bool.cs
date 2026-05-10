using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter12flush_bufferEb")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::flush_buffer(bool)")]
internal static partial class printf_core_FloatWriter_flush_buffer_bool
{
	public unsafe static int Invoke(void* @this, bool round_up_max_blocks)
	{
		int result = 0;
		sbyte new_char = 0;
		int num = 0;
		long num2 = 0L;
		int num3 = 0;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		int num4 = 0;
		int num5 = 0;
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		int num6 = 0;
		cpp_string_view cpp_string_view4 = default(cpp_string_view);
		long num7 = 0L;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		sbyte b = (round_up_max_blocks ? ((sbyte)1) : ((sbyte)0));
		llvm_lifetime_start_p0.Invoke(1L, &new_char);
		new_char = InstructionHelper.Select((b & 1) == 1, (sbyte)48, (sbyte)57);
		int num12;
		unchecked
		{
			if ((((printf_core_FloatWriter*)@this)->has_written & 1) != 1)
			{
				((printf_core_FloatWriter*)@this)->has_written = 1;
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = printf_core_PaddingWriter_write_left_padding_printf_core_Writer_unsigned_long.Invoke(&((printf_core_FloatWriter*)@this)->padding_writer, ((printf_core_FloatWriter*)@this)->writer, ((printf_core_FloatWriter*)@this)->total_digits);
				if (num < 0)
				{
					result = num;
					num12 = 1;
				}
				else
				{
					num12 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				switch (num12)
				{
				case 0:
					break;
				default:
					goto IL_06d3;
				}
			}
			if ((ulong)((printf_core_FloatWriter*)@this)->total_digits_written >= (ulong)((printf_core_FloatWriter*)@this)->digits_before_decimal || (ulong)(((printf_core_FloatWriter*)@this)->total_digits_written + ((printf_core_FloatWriter*)@this)->buffered_digits) < (ulong)((printf_core_FloatWriter*)@this)->digits_before_decimal || (((printf_core_FloatWriter*)@this)->has_decimal_point & 1) != 1)
			{
				goto IL_0325;
			}
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = ((printf_core_FloatWriter*)@this)->digits_before_decimal - ((printf_core_FloatWriter*)@this)->total_digits_written;
			if ((ulong)num2 > 0uL)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				void* writer = ((printf_core_FloatWriter*)@this)->writer;
				cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, &((printf_core_FloatWriter*)@this)->block_buffer, num2);
				num3 = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
				if (num3 < 0)
				{
					result = num3;
					num12 = 1;
				}
				else
				{
					num12 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				switch (num12)
				{
				case 0:
					break;
				default:
					goto IL_0304;
				}
			}
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = printf_core_Writer_write_char.Invoke(((printf_core_FloatWriter*)@this)->writer, 46);
			if (num4 < 0)
			{
				result = num4;
				num12 = 1;
			}
			else
			{
				num12 = 0;
			}
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			switch (num12)
			{
			case 0:
				{
					if ((ulong)(((printf_core_FloatWriter*)@this)->buffered_digits - num2) > 0uL)
					{
						llvm_lifetime_start_p0.Invoke(4L, &num5);
						void* writer2 = ((printf_core_FloatWriter*)@this)->writer;
						cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view3, (byte*)(&((printf_core_FloatWriter*)@this)->block_buffer) + num2, ((printf_core_FloatWriter*)@this)->buffered_digits - num2);
						num5 = printf_core_Writer_write_cpp_string_view.Invoke(writer2, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
						if (num5 < 0)
						{
							result = num5;
							num12 = 1;
						}
						else
						{
							num12 = 0;
						}
						llvm_lifetime_end_p0.Invoke(4L, &num5);
						switch (num12)
						{
						case 0:
							break;
						default:
							goto end_IL_0221;
						}
					}
					long num13 = ((printf_core_FloatWriter*)@this)->buffered_digits + 1L;
					((printf_core_FloatWriter*)@this)->total_digits_written += num13;
					((printf_core_FloatWriter*)@this)->buffered_digits = 0L;
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
			if ((ulong)((printf_core_FloatWriter*)@this)->buffered_digits > 0uL)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num6);
				void* writer3 = ((printf_core_FloatWriter*)@this)->writer;
				cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view4, &((printf_core_FloatWriter*)@this)->block_buffer, ((printf_core_FloatWriter*)@this)->buffered_digits);
				num6 = printf_core_Writer_write_cpp_string_view.Invoke(writer3, *(void**)(&cpp_string_view4), ((long*)(&cpp_string_view4))[1]);
				if (num6 < 0)
				{
					result = num6;
					num12 = 1;
				}
				else
				{
					num12 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num6);
				switch (num12)
				{
				case 0:
					break;
				default:
					goto IL_06d3;
				}
				long buffered_digits = ((printf_core_FloatWriter*)@this)->buffered_digits;
				((printf_core_FloatWriter*)@this)->total_digits_written += buffered_digits;
				((printf_core_FloatWriter*)@this)->buffered_digits = 0L;
			}
			if ((ulong)((printf_core_FloatWriter*)@this)->total_digits_written >= (ulong)((printf_core_FloatWriter*)@this)->digits_before_decimal || (ulong)(((printf_core_FloatWriter*)@this)->total_digits_written + 9L * ((printf_core_FloatWriter*)@this)->max_block_count) < (ulong)((printf_core_FloatWriter*)@this)->digits_before_decimal || (((printf_core_FloatWriter*)@this)->has_decimal_point & 1) != 1)
			{
				goto IL_0619;
			}
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = ((printf_core_FloatWriter*)@this)->digits_before_decimal - ((printf_core_FloatWriter*)@this)->total_digits_written;
			if ((ulong)num7 > 0uL)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num8);
				num8 = printf_core_Writer_write_char_unsigned_long.Invoke(((printf_core_FloatWriter*)@this)->writer, new_char, num7);
				if (num8 < 0)
				{
					result = num8;
					num12 = 1;
				}
				else
				{
					num12 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num8);
				switch (num12)
				{
				case 0:
					break;
				default:
					goto IL_05f8;
				}
			}
			llvm_lifetime_start_p0.Invoke(4L, &num9);
			num9 = printf_core_Writer_write_char.Invoke(((printf_core_FloatWriter*)@this)->writer, 46);
			if (num9 < 0)
			{
				result = num9;
				num12 = 1;
			}
			else
			{
				num12 = 0;
			}
			llvm_lifetime_end_p0.Invoke(4L, &num9);
			switch (num12)
			{
			case 0:
				{
					if ((ulong)(9L * ((printf_core_FloatWriter*)@this)->max_block_count - num7) > 0uL)
					{
						llvm_lifetime_start_p0.Invoke(4L, &num10);
						num10 = printf_core_Writer_write_char_unsigned_long.Invoke(((printf_core_FloatWriter*)@this)->writer, new_char, 9L * ((printf_core_FloatWriter*)@this)->max_block_count - num7);
						if (num10 < 0)
						{
							result = num10;
							num12 = 1;
						}
						else
						{
							num12 = 0;
						}
						llvm_lifetime_end_p0.Invoke(4L, &num10);
						switch (num12)
						{
						case 0:
							break;
						default:
							goto end_IL_050f;
						}
					}
					long max_block_count = ((printf_core_FloatWriter*)@this)->max_block_count;
					((printf_core_FloatWriter*)@this)->total_digits_written += 9L * max_block_count + 1L;
					((printf_core_FloatWriter*)@this)->max_block_count = 0L;
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
			if ((ulong)((printf_core_FloatWriter*)@this)->max_block_count > 0uL)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num11);
				num11 = printf_core_Writer_write_char_unsigned_long.Invoke(((printf_core_FloatWriter*)@this)->writer, new_char, ((printf_core_FloatWriter*)@this)->max_block_count * 9L);
				if (num11 < 0)
				{
					result = num11;
					num12 = 1;
				}
				else
				{
					num12 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num11);
				switch (num12)
				{
				case 0:
					break;
				default:
					goto IL_06d3;
				}
				long num14 = ((printf_core_FloatWriter*)@this)->max_block_count * 9L;
				((printf_core_FloatWriter*)@this)->total_digits_written += num14;
				((printf_core_FloatWriter*)@this)->max_block_count = 0L;
			}
			result = 0;
			goto IL_06d3;
		}
		IL_05f8:
		llvm_lifetime_end_p0.Invoke(8L, &num7);
		switch (num12)
		{
		case 0:
			break;
		default:
			goto IL_06d3;
		}
		goto IL_0619;
		IL_06d3:
		llvm_lifetime_end_p0.Invoke(1L, &new_char);
		return result;
		IL_0304:
		llvm_lifetime_end_p0.Invoke(8L, &num2);
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
