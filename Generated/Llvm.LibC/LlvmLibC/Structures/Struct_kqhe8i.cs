using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[CleanName("Struct")]
public partial struct Struct_kqhe8i
{
	[FieldOffset(0)]
	public unsafe void* field_0;

	[FieldOffset(8)]
	public long field_1;
}
