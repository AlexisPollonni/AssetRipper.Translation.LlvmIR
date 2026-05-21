using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AllocChecker_Assignment
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12AllocCheckeraSEb")]
	[DemangledName("__llvm_libc_20_1_2_::AllocChecker::operator=(bool)")]
	public unsafe static void* Invoke([MangledName("this")] void* This, [MangledName("status")][NativeType("bool")] bool Status)
	{
		sbyte b = (Status ? ((sbyte)1) : ((sbyte)0));
		unchecked((Anon_izyfb7*)This)->Val = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		return This;
	}
}
