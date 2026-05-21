using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_10NumberPairIdEE")]
[MangledName("struct.__llvm_libc_20_1_2_::NumberPair")]
[DemangledName("__llvm_libc_20_1_2_::NumberPair")]
public partial struct Llvm_libc_20_1_2_NumberPair
{
	[FieldOffset(0)]
	public double Lo;

	[FieldOffset(8)]
	public double Hi;
}
