using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core13PaddingWriter18write_left_paddingEPNS0_6WriterEm")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::PaddingWriter::write_left_padding(__llvm_libc_20_1_2_::printf_core::Writer*, unsigned long)")]
internal static partial class printf_core_PaddingWriter_write_left_padding_printf_core_Writer_unsigned_long
{
	public unsafe static int Invoke(void* @this, void* writer, long total_digits)
	{
		int result = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (int)(((printf_core_PaddingWriter*)@this)->min_width - total_digits - InstructionHelper.Select(((printf_core_PaddingWriter*)@this)->sign_char > 0, 1, 0));
			if ((((printf_core_PaddingWriter*)@this)->left_justified & 1) == 1 || num < 0)
			{
				if (((printf_core_PaddingWriter*)@this)->sign_char > 0)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = printf_core_Writer_write_char.Invoke(writer, ((printf_core_PaddingWriter*)@this)->sign_char);
					int num6;
					if (num2 < 0)
					{
						result = num2;
						num6 = 1;
					}
					else
					{
						num6 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num2);
					switch (num6)
					{
					case 0:
						break;
					default:
						goto IL_0205;
					}
				}
				result = 0;
			}
			else
			{
				if ((((printf_core_PaddingWriter*)@this)->leading_zeroes & 1) != 1)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = printf_core_Writer_write_char_unsigned_long.Invoke(writer, 32, num);
					int num6;
					if (num3 < 0)
					{
						result = num3;
						num6 = 1;
					}
					else
					{
						num6 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					switch (num6)
					{
					case 0:
						break;
					default:
						goto IL_0205;
					}
				}
				if (((printf_core_PaddingWriter*)@this)->sign_char > 0)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = printf_core_Writer_write_char.Invoke(writer, ((printf_core_PaddingWriter*)@this)->sign_char);
					int num6;
					if (num4 < 0)
					{
						result = num4;
						num6 = 1;
					}
					else
					{
						num6 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num4);
					switch (num6)
					{
					case 0:
						break;
					default:
						goto IL_0205;
					}
				}
				if ((((printf_core_PaddingWriter*)@this)->leading_zeroes & 1) == 1)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = printf_core_Writer_write_char_unsigned_long.Invoke(writer, 48, num);
					int num6;
					if (num5 < 0)
					{
						result = num5;
						num6 = 1;
					}
					else
					{
						num6 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num5);
					switch (num6)
					{
					case 0:
						break;
					default:
						goto IL_0205;
					}
				}
				result = 0;
			}
			goto IL_0205;
		}
		IL_0205:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
