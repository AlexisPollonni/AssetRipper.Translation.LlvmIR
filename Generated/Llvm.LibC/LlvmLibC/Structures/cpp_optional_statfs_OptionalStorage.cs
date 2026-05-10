using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 128)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<statfs>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::OptionalStorage")]
public partial struct cpp_optional_statfs_OptionalStorage
{
	[FieldOffset(0)]
	public anon_um3f5q field;

	[FieldOffset(120)]
	public sbyte in_use;

	[FieldOffset(121)]
	public InlineArray7_SByte field_2;
}
