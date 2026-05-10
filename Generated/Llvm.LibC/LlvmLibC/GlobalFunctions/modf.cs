namespace LlvmLibC.GlobalFunctions;

internal static partial class modf
{
	public unsafe static double Invoke(double x, void* iptr)
	{
		return double_fputil_modf_double_0_double_double.Invoke(x, iptr);
	}
}
