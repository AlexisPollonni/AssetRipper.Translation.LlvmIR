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
	public fputil_FPBits_ubgsi2 float_bits;

	[FieldOffset(16)]
	public sbyte is_negative;

	[FieldOffset(20)]
	public int exponent;

	[FieldOffset(32)]
	public Int128 mantissa;

	[FieldOffset(48)]
	public BigInt_q8g275 float_as_fixed;

	[FieldOffset(2112)]
	public int int_block_index;

	[FieldOffset(2116)]
	public InlineArray549_Int32 block_buffer;

	[FieldOffset(4312)]
	public long block_buffer_valid;
}
