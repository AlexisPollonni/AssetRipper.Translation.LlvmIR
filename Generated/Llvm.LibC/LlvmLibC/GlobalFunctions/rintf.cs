using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class rintf
{
	public static float Invoke(float x)
	{
		return llvm_rint_f32.Invoke(x);
	}
}
