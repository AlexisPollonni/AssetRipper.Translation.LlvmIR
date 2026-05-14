using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp5arrayImLm3EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::array.6452")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array")]
[CleanName("cpp_array")]
public partial struct cpp_array_tqfcue
{
	[FieldOffset(0)]
	public InlineArray3_Int64 Data;
}
