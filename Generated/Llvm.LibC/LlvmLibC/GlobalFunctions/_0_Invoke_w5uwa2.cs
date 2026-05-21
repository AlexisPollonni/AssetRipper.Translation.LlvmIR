using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _0_Invoke_w5uwa2
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_19__strcasestr_impl__EPKcS1_ENK3$_0clEcc")]
	[DemangledName("__llvm_libc_20_1_2_::__strcasestr_impl__(char const*, char const*)::$_0::operator()(char, char) const")]
	[CleanName("_0_Invoke")]
	public unsafe static int Invoke(void* @this, [NativeType("char")] sbyte a, [NativeType("char")] sbyte b)
	{
		return internal_tolower_vp4cqr.Invoke(a) - internal_tolower_vp4cqr.Invoke(b);
	}
}
