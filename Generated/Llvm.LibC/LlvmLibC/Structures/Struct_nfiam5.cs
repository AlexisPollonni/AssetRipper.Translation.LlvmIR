using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[CleanName("Struct")]
public partial struct Struct_nfiam5
{
	[FieldOffset(0)]
	public int field_0;

	[FieldOffset(8)]
	public long field_1;
}
