using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_19LargeRangeReductionE")]
[MangledName("struct.__llvm_libc_20_1_2_::LargeRangeReduction")]
[DemangledName("__llvm_libc_20_1_2_::LargeRangeReduction")]
public partial struct LargeRangeReduction
{
	[FieldOffset(0)]
	public int idx;

	[FieldOffset(8)]
	public double x_reduced;

	[FieldOffset(16)]
	public double y_hi;

	[FieldOffset(24)]
	public double y_lo;

	[FieldOffset(32)]
	public NumberPair y_mid;
}
