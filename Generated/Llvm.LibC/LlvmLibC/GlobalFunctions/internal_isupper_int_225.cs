using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isupperEi.225")]
[DemangledName("__llvm_libc_20_1_2_::internal::isupper(int) (.225)")]
internal static partial class internal_isupper_int_225
{
	public static bool Invoke(int ch)
	{
		if (ch == 65 || ch == 66 || ch == 67 || ch == 68 || ch == 69 || ch == 70 || ch == 71 || ch == 72 || ch == 73 || ch == 74 || ch == 75 || ch == 76 || ch == 77 || ch == 78 || ch == 79 || ch == 80 || ch == 81 || ch == 82 || ch == 83 || ch == 84 || ch == 85 || ch == 86 || ch == 87 || ch == 88 || ch == 89 || ch == 90)
		{
			return true;
		}
		return false;
	}
}
