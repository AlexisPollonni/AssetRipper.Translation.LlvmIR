using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<_Float16>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::OptionalStorage")]
public partial struct cpp_optional_Float16_OptionalStorage
{
	[FieldOffset(0)]
	public anon_juyca8 field;

	[FieldOffset(2)]
	public sbyte in_use;

	[FieldOffset(3)]
	public sbyte field_2;
}
