namespace LlvmLibC.GlobalFunctions;

internal static partial class issignaling
{
	public unsafe static int Invoke(double x)
	{
		double num = x;
		return int_fputil_issignaling_impl_double_0_double_const.Invoke(&num);
	}
}
