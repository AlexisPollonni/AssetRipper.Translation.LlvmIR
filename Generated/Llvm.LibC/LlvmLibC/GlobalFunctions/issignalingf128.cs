namespace LlvmLibC.GlobalFunctions;

internal static partial class issignalingf128
{
	public unsafe static int Invoke(double x)
	{
		double num = x;
		return fputil_issignaling_impl_float128_0.Invoke(&num);
	}
}
