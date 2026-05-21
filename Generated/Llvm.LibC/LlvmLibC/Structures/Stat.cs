using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 144)]
[MangledName("_ZTS4stat")]
[MangledName("struct.stat")]
[DemangledName("stat")]
public partial struct Stat
{
	[FieldOffset(0)]
	public long St_dev;

	[FieldOffset(8)]
	public long St_ino;

	[FieldOffset(16)]
	public long St_nlink;

	[FieldOffset(24)]
	public int St_mode;

	[FieldOffset(28)]
	public int St_uid;

	[FieldOffset(32)]
	public int St_gid;

	[FieldOffset(36)]
	public int Pad0;

	[FieldOffset(40)]
	public long St_rdev;

	[FieldOffset(48)]
	public long St_size;

	[FieldOffset(56)]
	public long St_blksize;

	[FieldOffset(64)]
	public long St_blocks;

	[FieldOffset(72)]
	public Llvm_libc_20_1_2_AuxEntry St_atim;

	[FieldOffset(88)]
	public Llvm_libc_20_1_2_AuxEntry St_mtim;

	[FieldOffset(104)]
	public Llvm_libc_20_1_2_AuxEntry St_ctim;

	[FieldOffset(120)]
	public InlineArray3_Int64 Glibc_reserved;
}
