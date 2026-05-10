using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<long double>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::OptionalStorage")]
public partial struct cpp_optional_long_double_OptionalStorage
{
	[FieldOffset(0)]
	public anon_mbc8w5 field;

	[FieldOffset(16)]
	public sbyte field_1;

	[FieldOffset(17)]
	public InlineArray15_SByte field_2;
}
