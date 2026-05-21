using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_isdigit_uq275v
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isdigitEi.28")]
	[DemangledName("__llvm_libc_20_1_2_::internal::isdigit(int) (.28)")]
	[CleanName("internal_isdigit")]
	public static bool Invoke([NativeType("int")] int ch)
	{
		if (ch == 48 || ch == 49 || ch == 50 || ch == 51 || ch == 52 || ch == 53 || ch == 54 || ch == 55 || ch == 56 || ch == 57)
		{
			return true;
		}
		return false;
	}
}
