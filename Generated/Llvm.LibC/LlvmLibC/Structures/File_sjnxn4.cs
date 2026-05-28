using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 128)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_4FileE")]
[MangledName("class.__llvm_libc_20_1_2_::File")]
[DemangledName("__llvm_libc_20_1_2_::File")]
[CleanName("File")]
public partial struct File_sjnxn4
{
	[FieldOffset(0)]
	public unsafe void* Platform_write;

	[FieldOffset(8)]
	public unsafe void* Platform_read;

	[FieldOffset(16)]
	public unsafe void* Platform_seek;

	[FieldOffset(24)]
	public unsafe void* Platform_close;

	[FieldOffset(32)]
	public Mutex Mutex;

	[FieldOffset(56)]
	public sbyte Ungetc_buf;

	[FieldOffset(57)]
	public InlineArray7_SByte field_6;

	[FieldOffset(64)]
	public unsafe void* Buf;

	[FieldOffset(72)]
	public long Bufsize;

	[FieldOffset(80)]
	public int Bufmode;

	[FieldOffset(84)]
	public sbyte Own_buf;

	[FieldOffset(85)]
	public InlineArray3_SByte field_11;

	[FieldOffset(88)]
	public int Mode;

	[FieldOffset(92)]
	public InlineArray4_SByte field_13;

	[FieldOffset(96)]
	public long Pos;

	[FieldOffset(104)]
	public FileOp Prev_op;

	[FieldOffset(105)]
	public InlineArray7_SByte field_16;

	[FieldOffset(112)]
	public long Read_limit;

	[FieldOffset(120)]
	public sbyte Eof;

	[FieldOffset(121)]
	public sbyte Err;

	[FieldOffset(122)]
	public InlineArray6_SByte field_20;
}
