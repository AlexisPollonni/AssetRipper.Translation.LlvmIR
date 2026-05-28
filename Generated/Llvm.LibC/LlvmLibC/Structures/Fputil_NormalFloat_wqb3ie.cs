using System;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil11NormalFloatIgEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::NormalFloat")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat")]
[CleanName("Fputil_NormalFloat")]
public partial struct Fputil_NormalFloat_wqb3ie
{
	[FieldOffset(0)]
	public int Exponent;

	[FieldOffset(4)]
	public InlineArray12_SByte field_1;

	[FieldOffset(16)]
	public Int128 Mantissa;

	[FieldOffset(32)]
	public Anon_izyfb7 Sign;

	[FieldOffset(33)]
	public InlineArray15_SByte field_4;
}
