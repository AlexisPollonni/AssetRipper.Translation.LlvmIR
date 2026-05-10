using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 128)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::array.1141")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array")]
[CleanName("cpp_array")]
public partial struct cpp_array_xx2b9m
{
	[FieldOffset(0)]
	public InlineArray32_Int32 Data;
}
