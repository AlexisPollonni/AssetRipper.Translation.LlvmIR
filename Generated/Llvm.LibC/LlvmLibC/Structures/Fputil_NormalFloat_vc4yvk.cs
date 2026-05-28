using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil11NormalFloatIdEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::NormalFloat.3209")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat")]
[CleanName("Fputil_NormalFloat")]
public partial struct Fputil_NormalFloat_vc4yvk
{
	[FieldOffset(0)]
	public int Exponent;

	[FieldOffset(4)]
	public InlineArray4_SByte field_1;

	[FieldOffset(8)]
	public long Mantissa;

	[FieldOffset(16)]
	public Anon_izyfb7 Sign;

	[FieldOffset(17)]
	public InlineArray7_SByte field_4;
}
