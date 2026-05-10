using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class truncf
{
	public static float Invoke(float x)
	{
		return llvm_trunc_f32.Invoke(x);
	}
}
