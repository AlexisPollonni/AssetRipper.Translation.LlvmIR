using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ceilf
{
	public static float Invoke(float x)
	{
		return llvm_ceil_f32.Invoke(x);
	}
}
