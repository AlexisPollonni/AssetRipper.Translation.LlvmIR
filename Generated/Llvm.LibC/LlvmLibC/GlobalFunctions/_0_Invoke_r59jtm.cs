using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _0_Invoke_r59jtm
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_15__strcmp_impl__EPKcS1_ENK3$_0clEcc")]
	[DemangledName("__llvm_libc_20_1_2_::__strcmp_impl__(char const*, char const*)::$_0::operator()(char, char) const")]
	[CleanName("_0_Invoke")]
	public unsafe static int Invoke([MangledName("this")] void* This, [MangledName("l")][NativeType("char")] sbyte L, [MangledName("r")][NativeType("char")] sbyte R)
	{
		return L - R;
	}
}
