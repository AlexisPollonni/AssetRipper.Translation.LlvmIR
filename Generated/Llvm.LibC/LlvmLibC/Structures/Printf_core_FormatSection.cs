using System;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 80)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_11printf_core13FormatSectionE")]
[MangledName("struct.__llvm_libc_20_1_2_::printf_core::FormatSection")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FormatSection")]
public partial struct Printf_core_FormatSection
{
	[FieldOffset(0)]
	public sbyte Has_conv;

	[FieldOffset(1)]
	public InlineArray7_SByte field_1;

	[FieldOffset(8)]
	public Cpp_string_view Raw_string;

	[FieldOffset(24)]
	public FormatFlags_hin2uh Flags;

	[FieldOffset(25)]
	public InlineArray3_SByte field_4;

	[FieldOffset(28)]
	public LengthModifier_mnvaa2 Length_modifier;

	[FieldOffset(32)]
	public long Bit_width;

	[FieldOffset(40)]
	public int Min_width;

	[FieldOffset(44)]
	public int Precision;

	[FieldOffset(48)]
	public Int128 Conv_val_raw;

	[FieldOffset(64)]
	public unsafe void* Conv_val_ptr;

	[FieldOffset(72)]
	public sbyte Conv_name;

	[FieldOffset(73)]
	public InlineArray7_SByte field_12;
}
