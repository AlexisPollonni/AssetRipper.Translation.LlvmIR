using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _0_Invoke_paa5ka
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_20__strncasecmp_impl__EPKcS1_mENK3$_0clEcc")]
	[DemangledName("__llvm_libc_20_1_2_::__strncasecmp_impl__(char const*, char const*, unsigned long)::$_0::operator()(char, char) const")]
	[CleanName("_0_Invoke")]
	public unsafe static int Invoke([MangledName("this")] void* This, [MangledName("a")][NativeType("char")] sbyte A, [MangledName("b")][NativeType("char")] sbyte B)
	{
		return Internal_tolower_rhnisd.Invoke(A) - Internal_tolower_rhnisd.Invoke(B);
	}
}
