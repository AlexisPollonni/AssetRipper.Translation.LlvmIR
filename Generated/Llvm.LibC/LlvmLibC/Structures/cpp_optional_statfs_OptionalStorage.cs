using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 128)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalI6statfsE15OptionalStorageIS2_Lb0EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<statfs>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::OptionalStorage")]
public partial struct cpp_optional_statfs_OptionalStorage
{
	[FieldOffset(0)]
	public anon_c6h438 field;

	[FieldOffset(120)]
	public sbyte in_use;

	[FieldOffset(121)]
	public InlineArray7_SByte field_2;
}
