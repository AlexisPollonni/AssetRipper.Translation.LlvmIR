namespace LlvmLibC.GlobalFunctions;

internal static partial class issignalingl
{
	public unsafe static int Invoke(double x)
	{
		double num = x;
		return int_fputil_issignaling_impl_long_double_0_long_double_const.Invoke(&num);
	}
}
