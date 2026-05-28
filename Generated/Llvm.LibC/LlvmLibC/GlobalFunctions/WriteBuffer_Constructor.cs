using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class WriteBuffer_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBufferC2EPcm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::WriteBuffer(char*, unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] Printf_core_WriteBuffer* This, [NativeType("char*")] void* Buff, [NativeType("unsigned long")] long Buff_len)
	{
		This->Buff = Buff;
		This->Init_buff = Buff;
		This->Buff_len = Buff_len;
		This->Buff_cur = 0L;
		This->Stream_writer = null;
		This->Output_target = null;
		This->Write_mode = WriteMode.FILL_BUFF_AND_DROP_OVERFLOW;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBufferC2EPcmPFiNS_3cpp11string_viewEPvE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::WriteBuffer(char*, unsigned long, int (*)(__llvm_libc_20_1_2_::cpp::string_view, void*))")]
	public unsafe static void Invoke([MangledName("this")] Printf_core_WriteBuffer* This, [NativeType("char*")] void* Buff, [NativeType("unsigned long")] long Buff_len, [MangledName("hook")][NativeType("int (*)(__llvm_libc_20_1_2_::cpp::string_view, void*)")] void* Hook)
	{
		This->Buff = Buff;
		This->Init_buff = Buff;
		This->Buff_len = Buff_len;
		This->Buff_cur = 0L;
		This->Stream_writer = Hook;
		This->Output_target = This;
		This->Write_mode = WriteMode.RESIZE_AND_FILL_BUFF;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBufferC2EPcmPFiNS_3cpp11string_viewEPvES5_")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::WriteBuffer(char*, unsigned long, int (*)(__llvm_libc_20_1_2_::cpp::string_view, void*), void*)")]
	public unsafe static void Invoke([MangledName("this")] Printf_core_WriteBuffer* This, [NativeType("char*")] void* Buff, [NativeType("unsigned long")] long Buff_len, [MangledName("hook")][NativeType("int (*)(__llvm_libc_20_1_2_::cpp::string_view, void*)")] void* Hook, [MangledName("target")][NativeType("void*")] void* Target)
	{
		This->Buff = Buff;
		This->Init_buff = Buff;
		This->Buff_len = Buff_len;
		This->Buff_cur = 0L;
		This->Stream_writer = Hook;
		This->Output_target = Target;
		This->Write_mode = WriteMode.FLUSH_TO_STREAM;
	}
}
