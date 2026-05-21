using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class LargeRangeReduction_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_19LargeRangeReductionC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::LargeRangeReduction::LargeRangeReduction()")]
	public unsafe static void Invoke(LargeRangeReduction* @this)
	{
		NumberPair_double_Constructor.Invoke(&@this->y_mid);
	}
}
