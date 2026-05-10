using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[CleanName("Struct")]
public partial struct Struct_u6p3uf
{
	[FieldOffset(0)]
	public long field_0;

	[FieldOffset(8)]
	public bool field_1;
}
