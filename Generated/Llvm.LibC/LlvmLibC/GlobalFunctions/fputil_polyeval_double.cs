using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_polyeval_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalIdEENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double) <= 8ul, double>::type __llvm_libc_20_1_2_::fputil::polyeval<double>(double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double) <= 8ul, double>::type")]
	public static double Invoke([NativeType("double")] double parameter_0, [NativeType("double")] double a0)
	{
		return a0;
	}
}
