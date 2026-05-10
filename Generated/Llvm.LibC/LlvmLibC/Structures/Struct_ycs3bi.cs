using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[CleanName("Struct")]
public partial struct Struct_ycs3bi
{
	[FieldOffset(0)]
	public int field_0;

	[FieldOffset(4)]
	public bool field_1;
}
