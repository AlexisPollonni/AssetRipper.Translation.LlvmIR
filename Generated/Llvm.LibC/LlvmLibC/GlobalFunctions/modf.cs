namespace LlvmLibC.GlobalFunctions;

internal static partial class modf
{
	public unsafe static double Invoke(double x, void* iptr)
	{
		return fputil_modf_double_0.Invoke(x, iptr);
	}
}
