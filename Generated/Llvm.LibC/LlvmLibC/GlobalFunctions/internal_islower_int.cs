using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7islowerEi")]
[DemangledName("__llvm_libc_20_1_2_::internal::islower(int)")]
internal static partial class internal_islower_int
{
	public static bool Invoke(int ch)
	{
		if (ch == 97 || ch == 98 || ch == 99 || ch == 100 || ch == 101 || ch == 102 || ch == 103 || ch == 104 || ch == 105 || ch == 106 || ch == 107 || ch == 108 || ch == 109 || ch == 110 || ch == 111 || ch == 112 || ch == 113 || ch == 114 || ch == 115 || ch == 116 || ch == 117 || ch == 118 || ch == 119 || ch == 120 || ch == 121 || ch == 122)
		{
			return true;
		}
		return false;
	}
}
