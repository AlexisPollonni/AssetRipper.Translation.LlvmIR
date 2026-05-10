using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<char *>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char *>::OptionalStorage")]
public partial struct cpp_optional_char_OptionalStorage
{
	[FieldOffset(0)]
	public anon_589mcc field;

	[FieldOffset(8)]
	public sbyte in_use;

	[FieldOffset(9)]
	public InlineArray7_SByte field_2;
}
