using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
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
