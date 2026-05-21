using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class integer_abs_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L11integer_absIxEENS_3cpp9enable_ifIXsr3cppE13is_integral_vIT_EES3_E4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<long long>, long long>::type __llvm_libc_20_1_2_::integer_abs<long long>(long long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<long long>, long long>::type")]
	public static long Invoke([NativeType("long long")] long n)
	{
		return (n >= 0L) ? n : (-n);
	}
}
