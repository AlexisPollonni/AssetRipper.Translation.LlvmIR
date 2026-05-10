using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class roundf
{
	public static float Invoke(float x)
	{
		return llvm_round_f32.Invoke(x);
	}
}
