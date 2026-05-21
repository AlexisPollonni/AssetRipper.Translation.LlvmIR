using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_sqrt_long_double_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIeeEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double> && cpp::is_floating_point_v<long double> && sizeof (long double) <= sizeof (long double), long double>::type __llvm_libc_20_1_2_::fputil::sqrt<long double, long double>(long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double> && cpp::is_floating_point_v<long double> && sizeof (long double) <= sizeof (long double), long double>::type")]
	public static double Invoke([NativeType("long double")] double x)
	{
		return IntrinsicFunctions.AsmFsqrt(x);
	}
}
