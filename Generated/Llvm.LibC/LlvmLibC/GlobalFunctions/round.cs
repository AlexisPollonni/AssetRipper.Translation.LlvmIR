using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class round
{
	public static double Invoke(double x)
	{
		return llvm_round_f64.Invoke(x);
	}
}
