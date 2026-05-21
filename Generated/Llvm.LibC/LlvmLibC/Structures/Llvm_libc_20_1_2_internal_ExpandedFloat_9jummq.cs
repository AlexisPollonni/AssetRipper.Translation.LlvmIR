using System;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8internal13ExpandedFloatIeEE")]
[MangledName("struct.__llvm_libc_20_1_2_::internal::ExpandedFloat.13")]
[DemangledName("__llvm_libc_20_1_2_::internal::ExpandedFloat")]
[CleanName("Llvm_libc_20_1_2_internal_ExpandedFloat")]
public partial struct Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq
{
	[FieldOffset(0)]
	public Int128 Mantissa;

	[FieldOffset(16)]
	public int Exponent;
}
