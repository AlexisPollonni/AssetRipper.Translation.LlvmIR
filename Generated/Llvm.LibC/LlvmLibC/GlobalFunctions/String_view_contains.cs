using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class String_view_contains
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view8containsEc")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::contains(char) const")]
	public unsafe static bool Invoke([MangledName("this")] void* This, [MangledName("c")][NativeType("char")] sbyte C)
	{
		return String_view_find_first_of.Invoke(This, C, 0L) != -1L;
	}
}
