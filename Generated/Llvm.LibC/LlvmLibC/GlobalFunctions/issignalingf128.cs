namespace LlvmLibC.GlobalFunctions;

internal static partial class issignalingf128
{
	public unsafe static int Invoke(double x)
	{
		double num = x;
		return int_fputil_issignaling_impl_float128_0_float128_const.Invoke(&num);
	}
}
