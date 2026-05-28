using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 96)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_11printf_core11FloatWriterE")]
[MangledName("class.__llvm_libc_20_1_2_::printf_core::FloatWriter")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter")]
public partial struct Printf_core_FloatWriter
{
	[FieldOffset(0)]
	public InlineArray9_SByte Block_buffer;

	[FieldOffset(16)]
	public long Buffered_digits;

	[FieldOffset(24)]
	public sbyte Has_written;

	[FieldOffset(32)]
	public long Max_block_count;

	[FieldOffset(40)]
	public long Total_digits;

	[FieldOffset(48)]
	public long Digits_before_decimal;

	[FieldOffset(56)]
	public long Total_digits_written;

	[FieldOffset(64)]
	public sbyte Has_decimal_point;

	[FieldOffset(72)]
	public unsafe Printf_core_Writer* Writer;

	[FieldOffset(80)]
	public Printf_core_PaddingWriter Padding_writer;
}
