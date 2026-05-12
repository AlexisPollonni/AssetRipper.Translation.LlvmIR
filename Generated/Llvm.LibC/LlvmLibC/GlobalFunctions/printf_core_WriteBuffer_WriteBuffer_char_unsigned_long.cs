using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBufferC2EPcm")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::WriteBuffer(char*, unsigned long)")]
internal static partial class printf_core_WriteBuffer_WriteBuffer_char_unsigned_long
{
	public unsafe static void Invoke(printf_core_WriteBuffer* @this, void* Buff, long Buff_len)
	{
		@this->buff = Buff;
		@this->init_buff = Buff;
		@this->buff_len = Buff_len;
		@this->buff_cur = 0L;
		@this->stream_writer = null;
		@this->output_target = null;
		@this->write_mode = WriteMode.FILL_BUFF_AND_DROP_OVERFLOW;
	}
}
