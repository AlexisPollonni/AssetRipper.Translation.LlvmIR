using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class trunc
{
	public static double Invoke(double x)
	{
		return llvm_trunc_f64.Invoke(x);
	}
}
