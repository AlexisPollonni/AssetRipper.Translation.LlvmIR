using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_view3minEmm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::min(unsigned long, unsigned long)")]
internal static partial class cpp_string_view_min_unsigned_long_unsigned_long
{
	public static long Invoke(long A, long B)
	{
		return unchecked((ulong)A > (ulong)B) ? B : A;
	}
}
