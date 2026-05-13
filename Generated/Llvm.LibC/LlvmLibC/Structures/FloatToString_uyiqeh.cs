using System;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("class.__llvm_libc_20_1_2_::FloatToString.6310")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString")]
[CleanName("FloatToString")]
public partial struct FloatToString_uyiqeh
{
	[FieldOffset(0)]
	public fputil_FPBits_5nkvcs float_bits;

	[FieldOffset(4)]
	public int exponent;

	[FieldOffset(16)]
	public Int128 mantissa;
}
