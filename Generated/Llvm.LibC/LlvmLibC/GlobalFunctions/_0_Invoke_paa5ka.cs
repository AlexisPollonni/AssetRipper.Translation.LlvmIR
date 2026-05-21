using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _0_Invoke_paa5ka
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_20__strncasecmp_impl__EPKcS1_mENK3$_0clEcc")]
	[DemangledName("__llvm_libc_20_1_2_::__strncasecmp_impl__(char const*, char const*, unsigned long)::$_0::operator()(char, char) const")]
	[CleanName("_0_Invoke")]
	public unsafe static int Invoke(void* @this, [NativeType("char")] sbyte a, [NativeType("char")] sbyte b)
	{
		return internal_tolower_rhnisd.Invoke(a) - internal_tolower_rhnisd.Invoke(b);
	}
}
