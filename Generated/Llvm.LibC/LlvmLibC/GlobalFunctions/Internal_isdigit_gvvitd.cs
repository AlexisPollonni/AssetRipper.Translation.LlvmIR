using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_isdigit_gvvitd
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isdigitEi.139")]
	[DemangledName("__llvm_libc_20_1_2_::internal::isdigit(int) (.139)")]
	[CleanName("Internal_isdigit")]
	public static bool Invoke([MangledName("ch")][NativeType("int")] int Ch)
	{
		if (Ch == 48 || Ch == 49 || Ch == 50 || Ch == 51 || Ch == 52 || Ch == 53 || Ch == 54 || Ch == 55 || Ch == 56 || Ch == 57)
		{
			return true;
		}
		return false;
	}
}
