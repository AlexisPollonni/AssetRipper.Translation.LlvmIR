using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class remainderl
{
	public unsafe static double Invoke(double x, double y)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		double result = long_double_fputil_remquo_long_double_0_long_double_long_double_int.Invoke(x, y, &num);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
