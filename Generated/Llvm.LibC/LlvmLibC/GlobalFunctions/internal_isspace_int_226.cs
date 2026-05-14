using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isspaceEi.226")]
[DemangledName("__llvm_libc_20_1_2_::internal::isspace(int) (.226)")]
internal static partial class internal_isspace_int_226
{
	public static bool Invoke(int ch)
	{
		if (ch == 32 || ch == 9 || ch == 10 || ch == 11 || ch == 12 || ch == 13)
		{
			return true;
		}
		return false;
	}
}
