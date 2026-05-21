using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_19LargeRangeReductionE")]
[MangledName("struct.__llvm_libc_20_1_2_::LargeRangeReduction")]
[DemangledName("__llvm_libc_20_1_2_::LargeRangeReduction")]
public partial struct Llvm_libc_20_1_2_LargeRangeReduction
{
	[FieldOffset(0)]
	public int Idx;

	[FieldOffset(8)]
	public double X_reduced;

	[FieldOffset(16)]
	public double Y_hi;

	[FieldOffset(24)]
	public double Y_lo;

	[FieldOffset(32)]
	public Llvm_libc_20_1_2_NumberPair Y_mid;
}
