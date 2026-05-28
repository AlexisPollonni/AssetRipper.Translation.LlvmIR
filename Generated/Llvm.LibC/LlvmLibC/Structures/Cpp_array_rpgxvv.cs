using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp5arrayImLm1EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::array.19")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array")]
[CleanName("Cpp_array")]
public partial struct Cpp_array_rpgxvv
{
	[FieldOffset(0)]
	public InlineArray1_Int64 Data;
}
