using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp5arrayImLm2EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::array.8")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array")]
[CleanName("Llvm_libc_20_1_2_cpp_array")]
public partial struct Llvm_libc_20_1_2_cpp_array_scvvei
{
	[FieldOffset(0)]
	public InlineArray4_Single Data;
}
