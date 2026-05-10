using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fabsf
{
	public static float Invoke(float x)
	{
		return llvm_fabs_f32.Invoke(x);
	}
}
