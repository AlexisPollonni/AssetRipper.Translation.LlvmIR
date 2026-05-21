using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 120)]
[MangledName("_ZTS6statfs")]
[MangledName("struct.statfs")]
[DemangledName("statfs")]
public partial struct Statfs
{
	[FieldOffset(0)]
	public long F_type;

	[FieldOffset(8)]
	public long F_bsize;

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
	public Kernel_fsid_t F_fsid;

	[FieldOffset(64)]
	public long F_namelen;

	[FieldOffset(72)]
	public long F_frsize;

	[FieldOffset(80)]
	public long F_flags;

	[FieldOffset(88)]
	public InlineArray4_Int64 F_spare;
}
