using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 3)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::array.6428")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array")]
[CleanName("cpp_array")]
public partial struct cpp_array_cdhstp
{
	[FieldOffset(0)]
	public InlineArray3_SByte Data;
}
