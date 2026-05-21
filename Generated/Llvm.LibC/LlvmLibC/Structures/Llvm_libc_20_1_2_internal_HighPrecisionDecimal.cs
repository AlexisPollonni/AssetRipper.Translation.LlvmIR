using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 812)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimalE")]
[MangledName("class.__llvm_libc_20_1_2_::internal::HighPrecisionDecimal")]
[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal")]
public partial struct Llvm_libc_20_1_2_internal_HighPrecisionDecimal
{
	[FieldOffset(0)]
	public int Num_digits;

	[FieldOffset(4)]
	public int Decimal_point;

	[FieldOffset(8)]
	public sbyte Truncated;

	[FieldOffset(9)]
	public InlineArray800_SByte Digits;

	[FieldOffset(809)]
	public InlineArray3_SByte field_4;
}
