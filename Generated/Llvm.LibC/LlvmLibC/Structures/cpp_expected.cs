using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("class.__llvm_libc_20_1_2_::cpp::expected")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected")]
public partial struct cpp_expected
{
	[FieldOffset(0)]
	public fputil_internal_FPStorage_v3nexn field;

	[FieldOffset(8)]
	public sbyte in_use;

	[FieldOffset(9)]
	public InlineArray7_SByte field_2;
}
