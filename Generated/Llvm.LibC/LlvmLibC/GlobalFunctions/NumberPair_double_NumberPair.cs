using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10NumberPairIdEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::NumberPair<double>::NumberPair()")]
internal static partial class NumberPair_double_NumberPair
{
	public unsafe static void Invoke(NumberPair* @this)
	{
		@this->lo = 0.0;
		@this->hi = 0.0;
	}
}
