using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::NormalFloat.3136")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat")]
[CleanName("fputil_NormalFloat")]
public partial struct fputil_NormalFloat_n2h9ta
{
	[FieldOffset(0)]
	public int exponent;

	[FieldOffset(4)]
	public InlineArray4_SByte field_1;

	[FieldOffset(8)]
	public long mantissa;

	[FieldOffset(16)]
	public anon_izyfb7 sign;

	[FieldOffset(17)]
	public InlineArray7_SByte field_4;
}
