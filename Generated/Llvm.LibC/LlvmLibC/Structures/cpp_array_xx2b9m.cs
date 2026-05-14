using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 128)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp5arrayIjLm32EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::array.1141")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array")]
[CleanName("cpp_array")]
public partial struct cpp_array_xx2b9m
{
	[FieldOffset(0)]
	public InlineArray32_Int32 Data;
}
