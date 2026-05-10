using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::NormalFloat.3129")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat")]
[CleanName("fputil_NormalFloat")]
public partial struct fputil_NormalFloat_i65f6x
{
	[FieldOffset(0)]
	public int exponent;

	[FieldOffset(4)]
	public int mantissa;

	[FieldOffset(8)]
	public anon_izyfb7 sign;

	[FieldOffset(9)]
	public InlineArray3_SByte field_3;
}
