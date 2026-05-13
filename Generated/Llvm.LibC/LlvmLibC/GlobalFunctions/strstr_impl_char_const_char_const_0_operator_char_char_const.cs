using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_15__strstr_impl__EPKcS1_ENK3$_0clEcc")]
[DemangledName("__llvm_libc_20_1_2_::__strstr_impl__(char const*, char const*)::$_0::operator()(char, char) const")]
internal static partial class strstr_impl_char_const_char_const_0_operator_char_char_const
{
	public unsafe static int Invoke(void* @this, sbyte l, sbyte r)
	{
		return l - r;
	}
}
