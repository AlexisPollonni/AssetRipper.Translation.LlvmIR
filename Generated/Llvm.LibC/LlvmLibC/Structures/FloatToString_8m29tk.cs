using System;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4320)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_13FloatToStringIeLi0EEE")]
[MangledName("class.__llvm_libc_20_1_2_::FloatToString")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString")]
[CleanName("FloatToString")]
public partial struct FloatToString_8m29tk
{
	[FieldOffset(0)]
	public Fputil_FPBits_ubgsi2 Float_bits;

	[FieldOffset(16)]
	public sbyte Is_negative;

	[FieldOffset(20)]
	public int Exponent;

	[FieldOffset(32)]
	public Int128 Mantissa;

	[FieldOffset(48)]
	public BigInt_q8g275 Float_as_fixed;

	[FieldOffset(2112)]
	public int Int_block_index;

	[FieldOffset(2116)]
	public InlineArray549_Int32 Block_buffer;

	[FieldOffset(4312)]
	public long Block_buffer_valid;
}
