using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 256)]
[MangledName("struct.(anonymous namespace)::statx_buf")]
[DemangledName("(anonymous namespace)::statx_buf")]
public partial struct anonymous_namespace_statx_buf
{
	[FieldOffset(0)]
	public int stx_mask;

	[FieldOffset(4)]
	public int stx_blksize;

	[FieldOffset(8)]
	public long stx_attributes;

	[FieldOffset(16)]
	public int stx_nlink;

	[FieldOffset(20)]
	public int stx_uid;

	[FieldOffset(24)]
	public int stx_gid;

	[FieldOffset(28)]
	public short stx_mode;

	[FieldOffset(30)]
	public InlineArray1_Int16 spare0;

	[FieldOffset(32)]
	public long stx_ino;

	[FieldOffset(40)]
	public long stx_size;

	[FieldOffset(48)]
	public long stx_blocks;

	[FieldOffset(56)]
	public long stx_attributes_mask;

	[FieldOffset(64)]
	public anonymous_namespace_statx_timestamp stx_atime;

	[FieldOffset(80)]
	public anonymous_namespace_statx_timestamp stx_btime;

	[FieldOffset(96)]
	public anonymous_namespace_statx_timestamp stx_ctime;

	[FieldOffset(112)]
	public anonymous_namespace_statx_timestamp stx_mtime;

	[FieldOffset(128)]
	public int stx_rdev_major;

	[FieldOffset(132)]
	public int stx_rdev_minor;

	[FieldOffset(136)]
	public int stx_dev_major;

	[FieldOffset(140)]
	public int stx_dev_minor;

	[FieldOffset(144)]
	public long stx_mnt_id;

	[FieldOffset(152)]
	public long spare2;

	[FieldOffset(160)]
	public InlineArray12_Int64 spare3;
}
