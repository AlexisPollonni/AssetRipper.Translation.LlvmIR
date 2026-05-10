using System;
using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 80)]
[MangledName("struct.__llvm_libc_20_1_2_::printf_core::FormatSection")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FormatSection")]
public partial struct printf_core_FormatSection
{
	[FieldOffset(0)]
	public sbyte has_conv;

	[FieldOffset(1)]
	public InlineArray7_SByte field_1;

	[FieldOffset(8)]
	public cpp_string_view raw_string;

	[FieldOffset(24)]
	public sbyte flags;

	[FieldOffset(25)]
	public InlineArray3_SByte field_4;

	[FieldOffset(28)]
	public int length_modifier;

	[FieldOffset(32)]
	public long bit_width;

	[FieldOffset(40)]
	public int min_width;

	[FieldOffset(44)]
	public int precision;

	[FieldOffset(48)]
	public Int128 conv_val_raw;

	[FieldOffset(64)]
	public unsafe void* conv_val_ptr;

	[FieldOffset(72)]
	public sbyte conv_name;

	[FieldOffset(73)]
	public InlineArray7_SByte field_12;
}
