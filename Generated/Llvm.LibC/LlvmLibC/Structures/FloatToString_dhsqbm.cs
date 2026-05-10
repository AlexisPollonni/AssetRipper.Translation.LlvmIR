using System;
using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("class.__llvm_libc_20_1_2_::FloatToString.6356")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString")]
[CleanName("FloatToString")]
public partial struct FloatToString_dhsqbm
{
	[FieldOffset(0)]
	public fputil_FPBits_wjhbrm float_bits;

	[FieldOffset(8)]
	public int field_1;

	[FieldOffset(16)]
	public Int128 mantissa;
}
