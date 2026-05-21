using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm16EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::DyadicFloat.1186")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat")]
[CleanName("Llvm_libc_20_1_2_fputil_DyadicFloat")]
public partial struct Llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm
{
	[FieldOffset(0)]
	public Anon_izyfb7 Sign;

	[FieldOffset(1)]
	public InlineArray3_SByte field_1;

	[FieldOffset(4)]
	public int Exponent;

	[FieldOffset(8)]
	public Llvm_libc_20_1_2_BigInt_ys7s55 Mantissa;

	[FieldOffset(10)]
	public InlineArray2_SByte field_4;
}
