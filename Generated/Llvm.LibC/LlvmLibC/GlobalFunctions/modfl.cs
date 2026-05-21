namespace LlvmLibC.GlobalFunctions;

internal static partial class modfl
{
	public unsafe static double Invoke(double x, void* iptr)
	{
		return fputil_modf_long_double_0.Invoke(x, iptr);
	}
}
