using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class floor
{
	public static double Invoke(double x)
	{
		return llvm_floor_f64.Invoke(x);
	}
}
