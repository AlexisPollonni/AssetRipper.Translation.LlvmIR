using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class string_view_contains
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view8containsEc")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::contains(char) const")]
	public unsafe static bool Invoke(void* @this, [NativeType("char")] sbyte c)
	{
		return string_view_find_first_of.Invoke(@this, c, 0L) != -1L;
	}
}
