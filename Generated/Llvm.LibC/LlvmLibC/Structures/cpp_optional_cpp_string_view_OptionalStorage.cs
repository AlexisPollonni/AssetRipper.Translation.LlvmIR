using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::OptionalStorage")]
public partial struct cpp_optional_cpp_string_view_OptionalStorage
{
	[FieldOffset(0)]
	public anon_t4s8je field;

	[FieldOffset(16)]
	public sbyte in_use;

	[FieldOffset(17)]
	public InlineArray7_SByte field_2;
}
