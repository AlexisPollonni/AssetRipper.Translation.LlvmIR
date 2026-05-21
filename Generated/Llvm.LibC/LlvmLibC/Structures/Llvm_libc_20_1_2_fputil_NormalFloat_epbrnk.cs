using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_EE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::NormalFloat.1348")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat")]
[CleanName("Llvm_libc_20_1_2_fputil_NormalFloat")]
public partial struct Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk
{
	[FieldOffset(0)]
	public int Exponent;

	[FieldOffset(4)]
	public short Mantissa;

	[FieldOffset(6)]
	public Anon_izyfb7 Sign;

	[FieldOffset(7)]
	public sbyte field_3;
}
