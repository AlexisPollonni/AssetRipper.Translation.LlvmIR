using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 88)]
[MangledName("_ZTS7statvfs")]
[MangledName("struct.statvfs")]
[DemangledName("statvfs")]
public partial struct Statvfs
{
	[FieldOffset(0)]
	public long F_bsize;

	[FieldOffset(8)]
	public long F_frsize;

	[FieldOffset(16)]
	public long F_blocks;

	[FieldOffset(24)]
	public long F_bfree;

	[FieldOffset(32)]
	public long F_bavail;

	[FieldOffset(40)]
	public long F_files;

	[FieldOffset(48)]
	public long F_ffree;

	[FieldOffset(56)]
	public long F_favail;

	[FieldOffset(64)]
	public long F_fsid;

	[FieldOffset(72)]
	public long F_flag;

	[FieldOffset(80)]
	public long F_namemax;
}
