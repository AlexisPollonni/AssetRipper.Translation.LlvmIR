using System;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_13FloatToStringIfLi0EEE")]
[MangledName("class.__llvm_libc_20_1_2_::FloatToString.6445")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString")]
[CleanName("FloatToString")]
public partial struct FloatToString_vnf553
{
	[FieldOffset(0)]
	public Fputil_FPBits_5nkvcs Float_bits;

	[FieldOffset(4)]
	public int Exponent;

	[FieldOffset(16)]
	public Int128 Mantissa;
}
