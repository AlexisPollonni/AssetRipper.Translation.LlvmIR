using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Integer_abs_long_ewbna6
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L11integer_absIlEENS_3cpp9enable_ifIXsr3cppE13is_integral_vIT_EES3_E4typeES3_.182")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<long>, long>::type __llvm_libc_20_1_2_::integer_abs<long>(long) (.182)")]
	[CleanName("Integer_abs_long")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<long>, long>::type")]
	public static long Invoke([MangledName("n")][NativeType("long")] long N)
	{
		return (N >= 0L) ? N : (-N);
	}
}
