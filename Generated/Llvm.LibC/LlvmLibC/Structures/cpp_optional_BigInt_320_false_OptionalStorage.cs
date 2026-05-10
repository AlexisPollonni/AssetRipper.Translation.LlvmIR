using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<320, false>>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<320, false>>::OptionalStorage")]
public partial struct cpp_optional_BigInt_320_false_OptionalStorage
{
	[FieldOffset(0)]
	public anon_28gi8s field;

	[FieldOffset(40)]
	public sbyte field_1;

	[FieldOffset(41)]
	public InlineArray7_SByte field_2;
}
