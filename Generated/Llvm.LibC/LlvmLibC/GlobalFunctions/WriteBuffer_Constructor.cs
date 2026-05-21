using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class WriteBuffer_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBufferC2EPcm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::WriteBuffer(char*, unsigned long)")]
	public unsafe static void Invoke(printf_core_WriteBuffer* @this, [NativeType("char*")] void* Buff, [NativeType("unsigned long")] long Buff_len)
	{
		@this->buff = Buff;
		@this->init_buff = Buff;
		@this->buff_len = Buff_len;
		@this->buff_cur = 0L;
		@this->stream_writer = null;
		@this->output_target = null;
		@this->write_mode = WriteMode.FILL_BUFF_AND_DROP_OVERFLOW;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBufferC2EPcmPFiNS_3cpp11string_viewEPvE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::WriteBuffer(char*, unsigned long, int (*)(__llvm_libc_20_1_2_::cpp::string_view, void*))")]
	public unsafe static void Invoke(printf_core_WriteBuffer* @this, [NativeType("char*")] void* Buff, [NativeType("unsigned long")] long Buff_len, [NativeType("int (*)(__llvm_libc_20_1_2_::cpp::string_view, void*)")] void* hook)
	{
		@this->buff = Buff;
		@this->init_buff = Buff;
		@this->buff_len = Buff_len;
		@this->buff_cur = 0L;
		@this->stream_writer = hook;
		@this->output_target = @this;
		@this->write_mode = WriteMode.RESIZE_AND_FILL_BUFF;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBufferC2EPcmPFiNS_3cpp11string_viewEPvES5_")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::WriteBuffer(char*, unsigned long, int (*)(__llvm_libc_20_1_2_::cpp::string_view, void*), void*)")]
	public unsafe static void Invoke(printf_core_WriteBuffer* @this, [NativeType("char*")] void* Buff, [NativeType("unsigned long")] long Buff_len, [NativeType("int (*)(__llvm_libc_20_1_2_::cpp::string_view, void*)")] void* hook, [NativeType("void*")] void* target)
	{
		@this->buff = Buff;
		@this->init_buff = Buff;
		@this->buff_len = Buff_len;
		@this->buff_cur = 0L;
		@this->stream_writer = hook;
		@this->output_target = target;
		@this->write_mode = WriteMode.FLUSH_TO_STREAM;
	}
}
