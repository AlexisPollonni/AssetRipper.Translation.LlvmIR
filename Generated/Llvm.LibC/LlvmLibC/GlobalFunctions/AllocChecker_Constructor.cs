using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AllocChecker_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12AllocCheckerC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::AllocChecker::AllocChecker()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked((Anon_izyfb7*)This)->Val = 0;
	}
}
