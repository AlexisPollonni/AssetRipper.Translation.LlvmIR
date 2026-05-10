using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class remainderf
{
	public unsafe static float Invoke(float x, float y)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		float result = float_fputil_remquo_float_0_float_float_int.Invoke(x, y, &num);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
