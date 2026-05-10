using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 88)]
[MangledName("struct.statvfs")]
public partial struct statvfs
{
	[FieldOffset(0)]
	public long f_bsize;

	[FieldOffset(8)]
	public long f_frsize;

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
	public long f_favail;

	[FieldOffset(64)]
	public long f_fsid;

	[FieldOffset(72)]
	public long f_flag;

	[FieldOffset(80)]
	public long f_namemax;
}
