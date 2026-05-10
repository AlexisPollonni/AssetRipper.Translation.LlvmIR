using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isgraphEi.227")]
[DemangledName("__llvm_libc_20_1_2_::internal::isgraph(int) (.227)")]
internal static partial class internal_isgraph_int_227
{
	public static bool Invoke(int ch)
	{
		return 32 < ch && ch < 127;
	}
}
