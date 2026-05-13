using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 144)]
[MangledName("struct.stat")]
public partial struct stat
{
	[FieldOffset(0)]
	public long st_dev;

	[FieldOffset(8)]
	public long st_ino;

	[FieldOffset(16)]
	public long st_nlink;

	[FieldOffset(24)]
	public int st_mode;

	[FieldOffset(28)]
	public int st_uid;

	[FieldOffset(32)]
	public int st_gid;

	[FieldOffset(36)]
	public int pad0;

	[FieldOffset(40)]
	public long st_rdev;

	[FieldOffset(48)]
	public long st_size;

	[FieldOffset(56)]
	public long st_blksize;

	[FieldOffset(64)]
	public long st_blocks;

	[FieldOffset(72)]
	public AuxEntry st_atim;

	[FieldOffset(88)]
	public AuxEntry st_mtim;

	[FieldOffset(104)]
	public AuxEntry st_ctim;

	[FieldOffset(120)]
	public InlineArray3_Int64 glibc_reserved;
}
