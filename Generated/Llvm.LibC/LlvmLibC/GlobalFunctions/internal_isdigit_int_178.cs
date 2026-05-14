using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isdigitEi.178")]
[DemangledName("__llvm_libc_20_1_2_::internal::isdigit(int) (.178)")]
internal static partial class internal_isdigit_int_178
{
	public static bool Invoke(int ch)
	{
		if (ch == 48 || ch == 49 || ch == 50 || ch == 51 || ch == 52 || ch == 53 || ch == 54 || ch == 55 || ch == 56 || ch == 57)
		{
			return true;
		}
		return false;
	}
}
