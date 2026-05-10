using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class isnanl
{
	public static int Invoke(double x)
	{
		return llvm_is_fpclass_f80.Invoke(x, 3) ? 1 : 0;
	}
}
