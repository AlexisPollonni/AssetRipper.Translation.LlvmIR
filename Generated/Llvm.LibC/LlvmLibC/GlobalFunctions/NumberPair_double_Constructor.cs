using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NumberPair_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10NumberPairIdEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::NumberPair<double>::NumberPair()")]
	public unsafe static void Invoke(NumberPair* @this)
	{
		@this->lo = 0.0;
		@this->hi = 0.0;
	}
}
