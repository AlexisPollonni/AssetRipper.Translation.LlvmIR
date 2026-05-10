using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class roundevenf
{
	public static float Invoke(float x)
	{
		return llvm_roundeven_f32.Invoke(x);
	}
}
