using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.(anonymous namespace)::statx_timestamp")]
[DemangledName("(anonymous namespace)::statx_timestamp")]
public partial struct anonymous_namespace_statx_timestamp
{
	[FieldOffset(0)]
	public long tv_sec;

	[FieldOffset(8)]
	public int tv_nsec;

	[FieldOffset(12)]
	public int reserved;
}
