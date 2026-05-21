using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 56)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_11printf_core11WriteBufferE")]
[MangledName("struct.__llvm_libc_20_1_2_::printf_core::WriteBuffer")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer")]
public partial struct Llvm_libc_20_1_2_printf_core_WriteBuffer
{
	[FieldOffset(0)]
	public unsafe void* Buff;

	[FieldOffset(8)]
	public unsafe void* Init_buff;

	[FieldOffset(16)]
	public long Buff_len;

	[FieldOffset(24)]
	public long Buff_cur;

	[FieldOffset(32)]
	public unsafe void* Stream_writer;

	[FieldOffset(40)]
	public unsafe void* Output_target;

	[FieldOffset(48)]
	public WriteMode Write_mode;

	[FieldOffset(52)]
	public InlineArray4_SByte field_7;
}
