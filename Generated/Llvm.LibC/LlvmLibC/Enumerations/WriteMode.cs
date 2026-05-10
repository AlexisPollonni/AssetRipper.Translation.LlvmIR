using LlvmLibC.Helpers;

namespace LlvmLibC.Enumerations;

[MangledName("_ZTSN19__llvm_libc_20_1_2_11printf_core11WriteBuffer9WriteModeE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::WriteMode")]
public enum WriteMode
{
	FILL_BUFF_AND_DROP_OVERFLOW,
	FLUSH_TO_STREAM,
	RESIZE_AND_FILL_BUFF
}
