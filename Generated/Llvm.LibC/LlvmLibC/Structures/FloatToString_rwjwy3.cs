using System;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_13FloatToStringIfLi0EEE")]
[MangledName("class.__llvm_libc_20_1_2_::FloatToString.6491")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString")]
[CleanName("FloatToString")]
public partial struct FloatToString_rwjwy3
{
	[FieldOffset(0)]
	public fputil_FPBits_wjhbrm float_bits;

	[FieldOffset(8)]
	public int field_1;

	[FieldOffset(16)]
	public Int128 mantissa;
}
