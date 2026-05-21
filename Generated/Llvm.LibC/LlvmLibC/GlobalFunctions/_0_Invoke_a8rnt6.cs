using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _0_Invoke_a8rnt6
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_19__strcasecmp_impl__EPKcS1_ENK3$_0clEcc")]
	[DemangledName("__llvm_libc_20_1_2_::__strcasecmp_impl__(char const*, char const*)::$_0::operator()(char, char) const")]
	[CleanName("_0_Invoke")]
	public unsafe static int Invoke([MangledName("this")] void* This, [MangledName("a")][NativeType("char")] sbyte A, [MangledName("b")][NativeType("char")] sbyte B)
	{
		return Internal_tolower_e9raaa.Invoke(A) - Internal_tolower_e9raaa.Invoke(B);
	}
}
