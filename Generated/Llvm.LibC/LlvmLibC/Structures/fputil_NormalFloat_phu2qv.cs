using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil11NormalFloatIfEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::NormalFloat.3202")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat")]
[CleanName("fputil_NormalFloat")]
public partial struct fputil_NormalFloat_phu2qv
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
