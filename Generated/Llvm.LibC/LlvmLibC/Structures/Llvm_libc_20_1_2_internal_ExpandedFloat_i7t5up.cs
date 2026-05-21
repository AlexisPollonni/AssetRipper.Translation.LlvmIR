using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8internal13ExpandedFloatIfEE")]
[MangledName("struct.__llvm_libc_20_1_2_::internal::ExpandedFloat.27")]
[DemangledName("__llvm_libc_20_1_2_::internal::ExpandedFloat")]
[CleanName("Llvm_libc_20_1_2_internal_ExpandedFloat")]
public partial struct Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up
{
	[FieldOffset(0)]
	public int Mantissa;

	[FieldOffset(4)]
	public int Exponent;
}
