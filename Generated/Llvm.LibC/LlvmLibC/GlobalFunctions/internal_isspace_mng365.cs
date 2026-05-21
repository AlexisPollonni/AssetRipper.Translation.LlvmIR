using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_isspace_mng365
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isspaceEi.148")]
	[DemangledName("__llvm_libc_20_1_2_::internal::isspace(int) (.148)")]
	[CleanName("internal_isspace")]
	public static bool Invoke([NativeType("int")] int ch)
	{
		if (ch == 32 || ch == 9 || ch == 10 || ch == 11 || ch == 12 || ch == 13)
		{
			return true;
		}
		return false;
	}
}
