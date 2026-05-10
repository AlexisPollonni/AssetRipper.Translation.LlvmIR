using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::DyadicFloat.1894")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat")]
[CleanName("fputil_DyadicFloat")]
public partial struct fputil_DyadicFloat_c8qpxg
{
	[FieldOffset(0)]
	public anon_izyfb7 sign;

	[FieldOffset(4)]
	public int exponent;

	[FieldOffset(8)]
	public BigInt_fzjdu3 mantissa;
}
