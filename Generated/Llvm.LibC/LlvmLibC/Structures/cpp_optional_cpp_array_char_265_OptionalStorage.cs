using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 266)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265>>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265>>::OptionalStorage")]
public partial struct cpp_optional_cpp_array_char_265_OptionalStorage
{
	[FieldOffset(0)]
	public anon_4b5q5z field;

	[FieldOffset(265)]
	public sbyte in_use;
}
