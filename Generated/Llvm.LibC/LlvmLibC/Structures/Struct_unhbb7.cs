using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[CleanName("Struct")]
public partial struct Struct_unhbb7
{
	[FieldOffset(0)]
	public double field_0;

	[FieldOffset(16)]
	public double field_1;
}
