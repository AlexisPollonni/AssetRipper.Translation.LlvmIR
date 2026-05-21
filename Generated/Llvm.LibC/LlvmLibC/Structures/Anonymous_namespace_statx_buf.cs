using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 256)]
[MangledName("struct.(anonymous namespace)::statx_buf")]
[DemangledName("(anonymous namespace)::statx_buf")]
public partial struct Anonymous_namespace_statx_buf
{
	[FieldOffset(0)]
	public int Stx_mask;

	[FieldOffset(4)]
	public int Stx_blksize;

	[FieldOffset(8)]
	public long Stx_attributes;

	[FieldOffset(16)]
	public int Stx_nlink;

	[FieldOffset(20)]
	public int Stx_uid;

	[FieldOffset(24)]
	public int Stx_gid;

	[FieldOffset(28)]
	public short Stx_mode;

	[FieldOffset(30)]
	public InlineArray1_Int16 Spare0;

	[FieldOffset(32)]
	public long Stx_ino;

	[FieldOffset(40)]
	public long Stx_size;

	[FieldOffset(48)]
	public long Stx_blocks;

	[FieldOffset(56)]
	public long Stx_attributes_mask;

	[FieldOffset(64)]
	public Anonymous_namespace_statx_timestamp Stx_atime;

	[FieldOffset(80)]
	public Anonymous_namespace_statx_timestamp Stx_btime;

	[FieldOffset(96)]
	public Anonymous_namespace_statx_timestamp Stx_ctime;

	[FieldOffset(112)]
	public Anonymous_namespace_statx_timestamp Stx_mtime;

	[FieldOffset(128)]
	public int Stx_rdev_major;

	[FieldOffset(132)]
	public int Stx_rdev_minor;

	[FieldOffset(136)]
	public int Stx_dev_major;

	[FieldOffset(140)]
	public int Stx_dev_minor;

	[FieldOffset(144)]
	public long Stx_mnt_id;

	[FieldOffset(152)]
	public long Spare2;

	[FieldOffset(160)]
	public InlineArray12_Int64 Spare3;
}
