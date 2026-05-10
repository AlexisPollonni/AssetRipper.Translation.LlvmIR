using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<double>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::OptionalStorage")]
public partial struct cpp_optional_double_OptionalStorage
{
	[FieldOffset(0)]
	public anon_6i3r2b field;

	[FieldOffset(8)]
	public sbyte in_use;

	[FieldOffset(9)]
	public InlineArray7_SByte field_2;
}
