using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 20)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil12ExceptValuesIfLm19EE7MappingE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues<float, 6>::Mapping")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues<float, 6>::Mapping")]
public partial struct Fputil_ExceptValues_float_6_Mapping
{
	[FieldOffset(0)]
	public int Input;

	[FieldOffset(4)]
	public int Rnd_towardzero_result;

	[FieldOffset(8)]
	public int Rnd_upward_offset;

	[FieldOffset(12)]
	public int Rnd_downward_offset;

	[FieldOffset(16)]
	public int Rnd_tonearest_offset;
}
