using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::array.3")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array")]
[CleanName("cpp_array")]
public partial struct cpp_array_dsir8b
{
	[FieldOffset(0)]
	public InlineArray8_Single Data;
}
