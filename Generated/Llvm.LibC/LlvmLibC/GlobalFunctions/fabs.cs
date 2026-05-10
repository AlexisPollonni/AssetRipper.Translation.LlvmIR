using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fabs
{
	public static double Invoke(double x)
	{
		return llvm_fabs_f64.Invoke(x);
	}
}
