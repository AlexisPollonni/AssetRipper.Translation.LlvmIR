using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NewArray
{
	[MangledName("_ZnamRN19__llvm_libc_20_1_2_12AllocCheckerE")]
	[DemangledName("operator new[](unsigned long, __llvm_libc_20_1_2_::AllocChecker&)")]
	public unsafe static void* Invoke([NativeType("unsigned long")] long size, [NativeType("__llvm_libc_20_1_2_::AllocChecker&")] void* ac)
	{
		return AllocChecker_alloc.Invoke(size, ac);
	}
}
