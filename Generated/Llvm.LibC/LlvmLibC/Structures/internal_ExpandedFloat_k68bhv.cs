using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8internal13ExpandedFloatIdEE")]
[MangledName("struct.__llvm_libc_20_1_2_::internal::ExpandedFloat")]
[DemangledName("__llvm_libc_20_1_2_::internal::ExpandedFloat")]
[CleanName("internal_ExpandedFloat")]
public partial struct internal_ExpandedFloat_k68bhv
{
	[FieldOffset(0)]
	public long mantissa;

	[FieldOffset(8)]
	public int exponent;
}
