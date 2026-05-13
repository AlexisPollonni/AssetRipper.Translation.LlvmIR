using System;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4)]
[CleanName("Struct")]
public partial struct Struct_zwcg27
{
	[FieldOffset(0)]
	public Half field_0;

	[FieldOffset(2)]
	public Half field_1;
}
