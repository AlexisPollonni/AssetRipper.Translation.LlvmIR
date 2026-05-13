using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 20)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues<float, 6>::Mapping")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues<float, 6>::Mapping")]
public partial struct fputil_ExceptValues_float_6_Mapping
{
	[FieldOffset(0)]
	public int input;

	[FieldOffset(4)]
	public int rnd_towardzero_result;

	[FieldOffset(8)]
	public int rnd_upward_offset;

	[FieldOffset(12)]
	public int rnd_downward_offset;

	[FieldOffset(16)]
	public int rnd_tonearest_offset;
}
