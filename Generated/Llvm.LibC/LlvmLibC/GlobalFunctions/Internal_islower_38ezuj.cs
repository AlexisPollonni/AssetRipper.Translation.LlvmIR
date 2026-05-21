using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_islower_38ezuj
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7islowerEi.170")]
	[DemangledName("__llvm_libc_20_1_2_::internal::islower(int) (.170)")]
	[CleanName("Internal_islower")]
	public static bool Invoke([MangledName("ch")][NativeType("int")] int Ch)
	{
		if (Ch == 97 || Ch == 98 || Ch == 99 || Ch == 100 || Ch == 101 || Ch == 102 || Ch == 103 || Ch == 104 || Ch == 105 || Ch == 106 || Ch == 107 || Ch == 108 || Ch == 109 || Ch == 110 || Ch == 111 || Ch == 112 || Ch == 113 || Ch == 114 || Ch == 115 || Ch == 116 || Ch == 117 || Ch == 118 || Ch == 119 || Ch == 120 || Ch == 121 || Ch == 122)
		{
			return true;
		}
		return false;
	}
}
