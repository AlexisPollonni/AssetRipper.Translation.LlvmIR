using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_isspace_8ceyuy
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isspaceEi.136")]
	[DemangledName("__llvm_libc_20_1_2_::internal::isspace(int) (.136)")]
	[CleanName("Internal_isspace")]
	public static bool Invoke([MangledName("ch")][NativeType("int")] int Ch)
	{
		if (Ch == 32 || Ch == 9 || Ch == 10 || Ch == 11 || Ch == 12 || Ch == 13)
		{
			return true;
		}
		return false;
	}
}
