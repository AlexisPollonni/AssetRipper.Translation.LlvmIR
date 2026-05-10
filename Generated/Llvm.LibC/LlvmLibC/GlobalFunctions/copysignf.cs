using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class copysignf
{
	public static float Invoke(float x, float y)
	{
		return llvm_copysign_f32.Invoke(x, y);
	}
}
