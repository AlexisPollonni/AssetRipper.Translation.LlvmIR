using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 10)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil12ExceptValuesIDF16_Lm8EE7MappingE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues<_Float16, 21>::Mapping")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues<_Float16, 21>::Mapping")]
public partial struct Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
{
	[FieldOffset(0)]
	public short Input;

	[FieldOffset(2)]
	public short Rnd_towardzero_result;

	[FieldOffset(4)]
	public short Rnd_upward_offset;

	[FieldOffset(6)]
	public short Rnd_downward_offset;

	[FieldOffset(8)]
	public short Rnd_tonearest_offset;
}
