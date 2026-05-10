using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6Writer5writeEcm")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::write(char, unsigned long)")]
internal static partial class printf_core_Writer_write_char_unsigned_long
{
	public unsafe static int Invoke(void* @this, sbyte new_char, long length)
	{
		sbyte b = new_char;
		unchecked((printf_core_Writer*)@this)->chars_written += unchecked((int)length);
		unchecked
		{
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ulong)(((printf_core_WriteBuffer*)((printf_core_Writer*)@this)->wb)->buff_cur + length) <= (ulong)((printf_core_WriteBuffer*)((printf_core_Writer*)@this)->wb)->buff_len, expected: true))
			{
				inline_memset_void_unsigned_char_unsigned_long_161.Invoke((byte*)((printf_core_WriteBuffer*)((printf_core_Writer*)@this)->wb)->buff + ((printf_core_WriteBuffer*)((printf_core_Writer*)@this)->wb)->buff_cur, b, length);
				((printf_core_WriteBuffer*)((printf_core_Writer*)@this)->wb)->buff_cur += length;
				return 0;
			}
			return printf_core_Writer_pad_char_unsigned_long.Invoke(@this, b, length);
		}
	}
}
