using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NumberPair_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10NumberPairIdEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::NumberPair<double>::NumberPair()")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_NumberPair* This)
	{
		This->Lo = 0.0;
		This->Hi = 0.0;
	}
}
