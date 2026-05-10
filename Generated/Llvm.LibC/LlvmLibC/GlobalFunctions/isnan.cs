using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class isnan
{
	public static int Invoke(double x)
	{
		return llvm_is_fpclass_f64.Invoke(x, 3) ? 1 : 0;
	}
}
