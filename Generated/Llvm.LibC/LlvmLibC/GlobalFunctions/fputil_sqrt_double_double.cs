using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_sqrt_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIddEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<double> && sizeof (double) <= sizeof (double), double>::type __llvm_libc_20_1_2_::fputil::sqrt<double, double>(double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<double> && sizeof (double) <= sizeof (double), double>::type")]
	public unsafe static double Invoke([NativeType("double")] double x)
	{
		double num = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = double.NaN;
		num = IntrinsicFunctions.AsmSqrtsd(x);
		double result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
