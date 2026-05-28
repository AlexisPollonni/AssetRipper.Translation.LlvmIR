using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 122)]
[MangledName("class.__llvm_libc_20_1_2_::File.base")]
[DemangledName("__llvm_libc_20_1_2_::File")]
[CleanName("File")]
public partial struct File_nubcdg
{
	[FieldOffset(0)]
	public unsafe void* field_0;

	[FieldOffset(8)]
	public unsafe void* field_1;

	[FieldOffset(16)]
	public unsafe void* field_2;

	[FieldOffset(24)]
	public unsafe void* field_3;

	[FieldOffset(32)]
	public Mutex field_4;

	[FieldOffset(56)]
	public sbyte field_5;

	[FieldOffset(57)]
	public InlineArray7_SByte field_6;

	[FieldOffset(64)]
	public unsafe void* field_7;

	[FieldOffset(72)]
	public long field_8;

	[FieldOffset(80)]
	public int field_9;

	[FieldOffset(84)]
	public sbyte field_10;

	[FieldOffset(85)]
	public InlineArray3_SByte field_11;

	[FieldOffset(88)]
	public int field_12;

	[FieldOffset(92)]
	public InlineArray4_SByte field_13;

	[FieldOffset(96)]
	public long field_14;

	[FieldOffset(104)]
	public sbyte field_15;

	[FieldOffset(105)]
	public InlineArray7_SByte field_16;

	[FieldOffset(112)]
	public long field_17;

	[FieldOffset(120)]
	public sbyte field_18;

	[FieldOffset(121)]
	public sbyte field_19;
}
