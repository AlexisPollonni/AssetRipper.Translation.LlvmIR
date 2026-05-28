using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil11NormalFloatIfEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::NormalFloat.3202")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat")]
[CleanName("Fputil_NormalFloat")]
public partial struct Fputil_NormalFloat_phu2qv
{
	[FieldOffset(0)]
	public int Exponent;

	[FieldOffset(4)]
	public int Mantissa;

	[FieldOffset(8)]
	public Anon_izyfb7 Sign;

	[FieldOffset(9)]
	public InlineArray3_SByte field_3;
}
