using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp5arrayImLm5EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::array.12.6429")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array")]
[CleanName("cpp_array")]
public partial struct cpp_array_msasyg
{
	[FieldOffset(0)]
	public InlineArray5_Int64 Data;
}
