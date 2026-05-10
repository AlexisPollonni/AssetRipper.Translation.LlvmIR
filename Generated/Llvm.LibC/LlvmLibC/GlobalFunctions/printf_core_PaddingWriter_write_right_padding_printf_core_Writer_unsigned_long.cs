using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core13PaddingWriter19write_right_paddingEPNS0_6WriterEm")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::PaddingWriter::write_right_padding(__llvm_libc_20_1_2_::printf_core::Writer*, unsigned long)")]
internal static partial class printf_core_PaddingWriter_write_right_padding_printf_core_Writer_unsigned_long
{
	public unsafe static int Invoke(void* @this, void* writer, long total_digits)
	{
		int result = 0;
		int num = 0;
		int num2 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (int)(((printf_core_PaddingWriter*)@this)->min_width - total_digits - InstructionHelper.Select(((printf_core_PaddingWriter*)@this)->sign_char > 0, 1, 0));
			if ((((printf_core_PaddingWriter*)@this)->left_justified & 1) == 1 && num > 0)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = printf_core_Writer_write_char_unsigned_long.Invoke(writer, 32, num);
				int num3;
				if (num2 < 0)
				{
					result = num2;
					num3 = 1;
				}
				else
				{
					num3 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				switch (num3)
				{
				case 0:
					break;
				default:
					goto IL_00b8;
				}
			}
			result = 0;
			goto IL_00b8;
		}
		IL_00b8:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
