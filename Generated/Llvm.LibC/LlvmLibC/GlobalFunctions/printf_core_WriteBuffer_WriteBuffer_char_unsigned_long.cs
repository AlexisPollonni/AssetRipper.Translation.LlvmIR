using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBufferC2EPcm")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::WriteBuffer(char*, unsigned long)")]
internal static partial class printf_core_WriteBuffer_WriteBuffer_char_unsigned_long
{
	public unsafe static void Invoke(void* @this, void* Buff, long Buff_len)
	{
		unchecked
		{
			((printf_core_WriteBuffer*)@this)->buff = Buff;
			((printf_core_WriteBuffer*)@this)->init_buff = Buff;
			((printf_core_WriteBuffer*)@this)->buff_len = Buff_len;
			((printf_core_WriteBuffer*)@this)->buff_cur = 0L;
			((printf_core_WriteBuffer*)@this)->stream_writer = null;
			((printf_core_WriteBuffer*)@this)->output_target = null;
			((printf_core_WriteBuffer*)@this)->write_mode = 0;
		}
	}
}
