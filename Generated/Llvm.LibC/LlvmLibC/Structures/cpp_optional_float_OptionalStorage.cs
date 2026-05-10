using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<float>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::OptionalStorage")]
public partial struct cpp_optional_float_OptionalStorage
{
	[FieldOffset(0)]
	public anon_rkx6n5 field;

	[FieldOffset(4)]
	public sbyte in_use;

	[FieldOffset(5)]
	public InlineArray3_SByte field_2;
}
