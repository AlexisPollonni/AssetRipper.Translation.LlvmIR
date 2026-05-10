using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 56)]
[MangledName("struct.__llvm_libc_20_1_2_::printf_core::WriteBuffer")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer")]
public partial struct printf_core_WriteBuffer
{
	[FieldOffset(0)]
	public unsafe void* buff;

	[FieldOffset(8)]
	public unsafe void* init_buff;

	[FieldOffset(16)]
	public long buff_len;

	[FieldOffset(24)]
	public long buff_cur;

	[FieldOffset(32)]
	public unsafe void* stream_writer;

	[FieldOffset(40)]
	public unsafe void* output_target;

	[FieldOffset(48)]
	public int write_mode;

	[FieldOffset(52)]
	public InlineArray4_SByte field_7;
}
