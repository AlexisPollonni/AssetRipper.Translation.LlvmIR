using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_17ExpRangeReductionE")]
[MangledName("struct.__llvm_libc_20_1_2_::ExpRangeReduction")]
[DemangledName("__llvm_libc_20_1_2_::ExpRangeReduction")]
public partial struct Llvm_libc_20_1_2_ExpRangeReduction
{
	[FieldOffset(0)]
	public float Exp_hi_mid;

	[FieldOffset(4)]
	public float Exp_lo;
}
