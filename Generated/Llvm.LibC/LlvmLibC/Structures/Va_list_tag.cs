using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTS13__va_list_tag")]
[MangledName("struct.__va_list_tag")]
[DemangledName("__va_list_tag")]
public partial struct Va_list_tag
{
	[FieldOffset(0)]
	public int Gp_offset;

	[FieldOffset(4)]
	public int Fp_offset;

	[FieldOffset(8)]
	public unsafe void* Overflow_arg_area;

	[FieldOffset(16)]
	public unsafe void* Reg_save_area;
}
