using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 128)]
[MangledName("class.__llvm_libc_20_1_2_::File")]
[DemangledName("__llvm_libc_20_1_2_::File")]
[CleanName("File")]
public partial struct File_sjnxn4
{
	[FieldOffset(0)]
	public unsafe void* platform_write;

	[FieldOffset(8)]
	public unsafe void* platform_read;

	[FieldOffset(16)]
	public unsafe void* platform_seek;

	[FieldOffset(24)]
	public unsafe void* platform_close;

	[FieldOffset(32)]
	public Mutex mutex;

	[FieldOffset(56)]
	public sbyte ungetc_buf;

	[FieldOffset(57)]
	public InlineArray7_SByte field_6;

	[FieldOffset(64)]
	public unsafe void* buf;

	[FieldOffset(72)]
	public long bufsize;

	[FieldOffset(80)]
	public int bufmode;

	[FieldOffset(84)]
	public sbyte own_buf;

	[FieldOffset(85)]
	public InlineArray3_SByte field_11;

	[FieldOffset(88)]
	public int mode;

	[FieldOffset(92)]
	public InlineArray4_SByte field_13;

	[FieldOffset(96)]
	public long pos;

	[FieldOffset(104)]
	public FileOp prev_op;

	[FieldOffset(105)]
	public InlineArray7_SByte field_16;

	[FieldOffset(112)]
	public long read_limit;

	[FieldOffset(120)]
	public sbyte eof;

	[FieldOffset(121)]
	public sbyte err;

	[FieldOffset(122)]
	public InlineArray6_SByte field_20;
}
