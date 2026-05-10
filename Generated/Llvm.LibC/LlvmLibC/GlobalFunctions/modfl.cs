namespace LlvmLibC.GlobalFunctions;

internal static partial class modfl
{
	public unsafe static double Invoke(double x, void* iptr)
	{
		return long_double_fputil_modf_long_double_0_long_double_long_double.Invoke(x, iptr);
	}
}
