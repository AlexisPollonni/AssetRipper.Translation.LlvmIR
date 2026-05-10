using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<128, false>>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<128, false>>::OptionalStorage")]
public partial struct cpp_optional_BigInt_128_false_OptionalStorage
{
	[FieldOffset(0)]
	public anon_2zhidv field;

	[FieldOffset(16)]
	public sbyte in_use;

	[FieldOffset(17)]
	public InlineArray7_SByte field_2;
}
