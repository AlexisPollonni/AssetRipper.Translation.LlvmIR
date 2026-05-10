using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 2072)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<16512, false>>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<16512, false>>::OptionalStorage")]
public partial struct cpp_optional_BigInt_16512_false_OptionalStorage
{
	[FieldOffset(0)]
	public anon_qmxqmw field;

	[FieldOffset(2064)]
	public sbyte in_use;

	[FieldOffset(2065)]
	public InlineArray7_SByte field_2;
}
