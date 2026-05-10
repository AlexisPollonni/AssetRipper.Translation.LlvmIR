using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::NormalFloat.1348")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat")]
[CleanName("fputil_NormalFloat")]
public partial struct fputil_NormalFloat_epbrnk
{
	[FieldOffset(0)]
	public int exponent;

	[FieldOffset(4)]
	public short mantissa;

	[FieldOffset(6)]
	public anon_izyfb7 sign;

	[FieldOffset(7)]
	public sbyte field_3;
}
