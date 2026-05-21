using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalIdE15OptionalStorageIdLb0EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<char *>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char *>::OptionalStorage")]
public partial struct Llvm_libc_20_1_2_cpp_optional_char_OptionalStorage
{
	[FieldOffset(0)]
	public Anon_5uk363 field;

	[FieldOffset(8)]
	public sbyte In_use;

	[FieldOffset(9)]
	public InlineArray7_SByte field_2;
}
