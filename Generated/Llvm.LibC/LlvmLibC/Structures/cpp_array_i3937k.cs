using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::array")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array")]
[CleanName("cpp_array")]
public partial struct cpp_array_i3937k
{
	[FieldOffset(0)]
	public InlineArray2_Int64 Data;
}
