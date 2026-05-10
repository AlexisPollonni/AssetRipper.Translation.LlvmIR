using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class copysign
{
	public static double Invoke(double x, double y)
	{
		return llvm_copysign_f64.Invoke(x, y);
	}
}
