using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.(anonymous namespace)::statx_timestamp")]
[DemangledName("(anonymous namespace)::statx_timestamp")]
public partial struct Anonymous_namespace_statx_timestamp
{
	[FieldOffset(0)]
	public long Tv_sec;

	[FieldOffset(8)]
	public int Tv_nsec;

	[FieldOffset(12)]
	public int Reserved;
}
