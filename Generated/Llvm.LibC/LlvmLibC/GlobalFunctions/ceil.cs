using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ceil
{
	public static double Invoke(double x)
	{
		return llvm_ceil_f64.Invoke(x);
	}
}
