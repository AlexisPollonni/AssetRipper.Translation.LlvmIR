using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalIDF16_E15OptionalStorageIDF16_Lb0EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<_Float16>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::OptionalStorage")]
public partial struct Cpp_optional_Float16_OptionalStorage
{
	[FieldOffset(0)]
	public Anon_juyca8 field;

	[FieldOffset(2)]
	public sbyte In_use;

	[FieldOffset(3)]
	public sbyte field_2;
}
