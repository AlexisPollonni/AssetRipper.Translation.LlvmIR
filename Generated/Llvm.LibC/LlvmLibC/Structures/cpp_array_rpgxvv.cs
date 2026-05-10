using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::array.19")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array")]
[CleanName("cpp_array")]
public partial struct cpp_array_rpgxvv
{
	[FieldOffset(0)]
	public InlineArray1_Int64 Data;
}
