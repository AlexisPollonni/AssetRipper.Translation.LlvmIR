using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_polyeval_double_double_double_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalIdJddddEEENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_DpT0_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double) <= 8ul, double>::type __llvm_libc_20_1_2_::fputil::polyeval<double, double, double, double, double>(double, double, double, double, double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double) <= 8ul, double>::type")]
	public static double Invoke([NativeType("double")] double x, [NativeType("double")] double a0, [MangledName("a")][CleanName("a")][NativeType("double")] double a_yc74sk, [MangledName("a1")][CleanName("a")][NativeType("double")] double a_ijazrn, [MangledName("a3")][CleanName("a")][NativeType("double")] double a_889uw5, [MangledName("a5")][CleanName("a")][NativeType("double")] double a_79nth8)
	{
		return fputil_multiply_add_double.Invoke(x, fputil_polyeval_double_double_double_double.Invoke(x, a_yc74sk, a_ijazrn, a_889uw5, a_79nth8), a0);
	}
}
