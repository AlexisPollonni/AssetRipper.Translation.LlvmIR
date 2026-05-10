using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 120)]
[MangledName("struct.statfs")]
public partial struct statfs
{
	[FieldOffset(0)]
	public long f_type;

	[FieldOffset(8)]
	public long f_bsize;

	[FieldOffset(16)]
	public long f_blocks;

	[FieldOffset(24)]
	public long f_bfree;

	[FieldOffset(32)]
	public long f_bavail;

	[FieldOffset(40)]
	public long f_files;

	[FieldOffset(48)]
	public long f_ffree;

	[FieldOffset(56)]
	public kernel_fsid_t f_fsid;

	[FieldOffset(64)]
	public long f_namelen;

	[FieldOffset(72)]
	public long f_frsize;

	[FieldOffset(80)]
	public long f_flags;

	[FieldOffset(88)]
	public InlineArray4_Int64 f_spare;
}
