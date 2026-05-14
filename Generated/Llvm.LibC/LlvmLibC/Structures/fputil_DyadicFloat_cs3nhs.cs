using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm16EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::DyadicFloat.1893")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat")]
[CleanName("fputil_DyadicFloat")]
public partial struct fputil_DyadicFloat_cs3nhs
{
	[FieldOffset(0)]
	public anon_izyfb7 sign;

	[FieldOffset(4)]
	public int exponent;

	[FieldOffset(8)]
	public BigInt_vtm4cw mantissa;
}
