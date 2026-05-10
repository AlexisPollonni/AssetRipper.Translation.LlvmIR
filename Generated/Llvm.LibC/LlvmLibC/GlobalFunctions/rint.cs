using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class rint
{
	public static double Invoke(double x)
	{
		return llvm_rint_f64.Invoke(x);
	}
}
