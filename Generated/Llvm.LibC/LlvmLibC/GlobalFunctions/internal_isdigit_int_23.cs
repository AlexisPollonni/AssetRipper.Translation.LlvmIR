using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isdigitEi.23")]
[DemangledName("__llvm_libc_20_1_2_::internal::isdigit(int) (.23)")]
internal static partial class internal_isdigit_int_23
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
