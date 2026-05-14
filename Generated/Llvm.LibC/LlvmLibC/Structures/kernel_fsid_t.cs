using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("_ZTS15__kernel_fsid_t")]
[MangledName("struct.__kernel_fsid_t")]
[DemangledName("__kernel_fsid_t")]
public partial struct kernel_fsid_t
{
	[FieldOffset(0)]
	public InlineArray2_Int32 val;
}
