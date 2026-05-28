using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8internal18FloatConvertReturnIfEE")]
[MangledName("struct.__llvm_libc_20_1_2_::internal::FloatConvertReturn.28")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn")]
[CleanName("Internal_FloatConvertReturn")]
public partial struct Internal_FloatConvertReturn_a8f9er
{
	[FieldOffset(0)]
	public Internal_ExpandedFloat_i7t5up Num;

	[FieldOffset(8)]
	public int Error;
}
