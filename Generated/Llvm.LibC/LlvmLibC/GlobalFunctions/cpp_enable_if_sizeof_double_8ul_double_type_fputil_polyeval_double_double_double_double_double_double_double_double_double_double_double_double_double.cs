using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalIdJdddddEEENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_DpT0_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double) <= 8ul, double>::type __llvm_libc_20_1_2_::fputil::polyeval<double, double, double, double, double, double>(double, double, double, double, double, double, double)")]
internal static partial class cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double_double_double_double_double_double_double
{
	public static double Invoke(double x, double a0, [MangledName("a")][CleanName("a")] double a_yc74sk, [MangledName("a1")][CleanName("a")] double a_ijazrn, [MangledName("a3")][CleanName("a")] double a_889uw5, [MangledName("a5")][CleanName("a")] double a_79nth8, [MangledName("a7")][CleanName("a")] double a_zvuc8k)
	{
		return cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double_double_double_double_double.Invoke(x, a_yc74sk, a_ijazrn, a_889uw5, a_79nth8, a_zvuc8k), a0);
	}
}
