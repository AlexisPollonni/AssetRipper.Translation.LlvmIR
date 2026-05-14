using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class isnanf
{
	public static int Invoke(float x)
	{
		return llvm_is_fpclass_f32.Invoke(x, 3) ? 1 : 0;
	}
}
