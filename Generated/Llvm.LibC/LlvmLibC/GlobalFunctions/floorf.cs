using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class floorf
{
	public static float Invoke(float x)
	{
		return llvm_floor_f32.Invoke(x);
	}
}
