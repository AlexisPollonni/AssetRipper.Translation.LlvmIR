using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 96)]
[MangledName("class.__llvm_libc_20_1_2_::printf_core::FloatWriter")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter")]
public partial struct printf_core_FloatWriter
{
	[FieldOffset(0)]
	public InlineArray9_SByte block_buffer;

	[FieldOffset(16)]
	public long buffered_digits;

	[FieldOffset(24)]
	public sbyte has_written;

	[FieldOffset(32)]
	public long max_block_count;

	[FieldOffset(40)]
	public long total_digits;

	[FieldOffset(48)]
	public long digits_before_decimal;

	[FieldOffset(56)]
	public long total_digits_written;

	[FieldOffset(64)]
	public sbyte has_decimal_point;

	[FieldOffset(72)]
	public unsafe printf_core_Writer* writer;

	[FieldOffset(80)]
	public printf_core_PaddingWriter padding_writer;
}
