using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AllocChecker_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12AllocCheckerC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::AllocChecker::AllocChecker()")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked((anon_izyfb7*)@this)->val = 0;
	}
}
