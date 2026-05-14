using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 812)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimalE")]
[MangledName("class.__llvm_libc_20_1_2_::internal::HighPrecisionDecimal")]
[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal")]
public partial struct internal_HighPrecisionDecimal
{
	[FieldOffset(0)]
	public int num_digits;

	[FieldOffset(4)]
	public int decimal_point;

	[FieldOffset(8)]
	public sbyte truncated;

	[FieldOffset(9)]
	public InlineArray800_SByte digits;

	[FieldOffset(809)]
	public InlineArray3_SByte field_4;
}
