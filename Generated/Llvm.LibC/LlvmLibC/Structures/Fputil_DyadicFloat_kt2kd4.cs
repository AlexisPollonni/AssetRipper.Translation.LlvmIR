using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::DyadicFloat")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat")]
[CleanName("Fputil_DyadicFloat")]
public partial struct Fputil_DyadicFloat_kt2kd4
{
	[FieldOffset(0)]
	public Anon_izyfb7 Sign;

	[FieldOffset(4)]
	public int Exponent;

	[FieldOffset(8)]
	public BigInt_qdkjbh Mantissa;
}
