using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L11integer_absIlEENS_3cpp9enable_ifIXsr3cppE13is_integral_vIT_EES3_E4typeES3_.180")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<long>, long>::type __llvm_libc_20_1_2_::integer_abs<long>(long) (.180)")]
internal static partial class cpp_enable_if_cpp_is_integral_v_long_long_type_integer_abs_long_long_180
{
	public static long Invoke(long n)
	{
		return (n >= 0L) ? n : (-n);
	}
}
