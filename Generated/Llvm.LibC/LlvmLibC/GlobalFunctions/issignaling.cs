namespace LlvmLibC.GlobalFunctions;

internal static partial class issignaling
{
	public unsafe static int Invoke(double x)
	{
		double num = x;
		return fputil_issignaling_impl_double_0.Invoke(&num);
	}
}
