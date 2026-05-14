using System;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil11NormalFloatIgEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::NormalFloat")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat")]
[CleanName("fputil_NormalFloat")]
public partial struct fputil_NormalFloat_wqb3ie
{
	[FieldOffset(0)]
	public int exponent;

	[FieldOffset(4)]
	public InlineArray12_SByte field_1;

	[FieldOffset(16)]
	public Int128 mantissa;

	[FieldOffset(32)]
	public anon_izyfb7 sign;

	[FieldOffset(33)]
	public InlineArray15_SByte field_4;
}
