using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_polyeval_double_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalIdJddEEENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_DpT0_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double) <= 8ul, double>::type __llvm_libc_20_1_2_::fputil::polyeval<double, double, double>(double, double, double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double) <= 8ul, double>::type")]
	public static double Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("a0")][NativeType("double")] double A0, [MangledName("a")][CleanName("A")][NativeType("double")] double A_yc74sk, [MangledName("a1")][CleanName("A")][NativeType("double")] double A_ijazrn)
	{
		return Fputil_multiply_add_double.Invoke(X, Fputil_polyeval_double_double.Invoke(X, A_yc74sk, A_ijazrn), A0);
	}
}
