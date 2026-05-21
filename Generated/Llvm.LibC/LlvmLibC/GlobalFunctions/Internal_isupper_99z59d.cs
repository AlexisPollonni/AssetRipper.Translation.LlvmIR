using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_isupper_99z59d
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isupperEi.225")]
	[DemangledName("__llvm_libc_20_1_2_::internal::isupper(int) (.225)")]
	[CleanName("Internal_isupper")]
	public static bool Invoke([MangledName("ch")][NativeType("int")] int Ch)
	{
		if (Ch == 65 || Ch == 66 || Ch == 67 || Ch == 68 || Ch == 69 || Ch == 70 || Ch == 71 || Ch == 72 || Ch == 73 || Ch == 74 || Ch == 75 || Ch == 76 || Ch == 77 || Ch == 78 || Ch == 79 || Ch == 80 || Ch == 81 || Ch == 82 || Ch == 83 || Ch == 84 || Ch == 85 || Ch == 86 || Ch == 87 || Ch == 88 || Ch == 89 || Ch == 90)
		{
			return true;
		}
		return false;
	}
}
