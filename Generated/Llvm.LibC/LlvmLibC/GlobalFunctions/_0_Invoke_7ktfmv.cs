using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _0_Invoke_7ktfmv
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_15__strstr_impl__EPKcS1_ENK3$_0clEcc")]
	[DemangledName("__llvm_libc_20_1_2_::__strstr_impl__(char const*, char const*)::$_0::operator()(char, char) const")]
	[CleanName("_0_Invoke")]
	public unsafe static int Invoke(void* @this, [NativeType("char")] sbyte l, [NativeType("char")] sbyte r)
	{
		return l - r;
	}
}
