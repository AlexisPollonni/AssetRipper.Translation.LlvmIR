using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[CleanName("Struct")]
public partial struct Struct_3driym
{
	[FieldOffset(0)]
	public long field_0;

	[FieldOffset(8)]
	public int field_1;
}
