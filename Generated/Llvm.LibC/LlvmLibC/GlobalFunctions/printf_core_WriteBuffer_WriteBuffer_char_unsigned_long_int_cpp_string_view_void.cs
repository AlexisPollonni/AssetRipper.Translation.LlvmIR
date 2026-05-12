using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBufferC2EPcmPFiNS_3cpp11string_viewEPvE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::WriteBuffer(char*, unsigned long, int (*)(__llvm_libc_20_1_2_::cpp::string_view, void*))")]
internal static partial class printf_core_WriteBuffer_WriteBuffer_char_unsigned_long_int_cpp_string_view_void
{
	public unsafe static void Invoke(printf_core_WriteBuffer* @this, void* Buff, long Buff_len, void* hook)
	{
		@this->buff = Buff;
		@this->init_buff = Buff;
		@this->buff_len = Buff_len;
		@this->buff_cur = 0L;
		@this->stream_writer = hook;
		@this->output_target = @this;
		@this->write_mode = WriteMode.RESIZE_AND_FILL_BUFF;
	}
}
