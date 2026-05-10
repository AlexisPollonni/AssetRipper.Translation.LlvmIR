using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class roundeven
{
	public static double Invoke(double x)
	{
		return llvm_roundeven_f64.Invoke(x);
	}
}
