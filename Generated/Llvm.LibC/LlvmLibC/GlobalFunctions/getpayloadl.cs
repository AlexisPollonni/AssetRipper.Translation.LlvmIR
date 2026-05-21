namespace LlvmLibC.GlobalFunctions;

internal static partial class getpayloadl
{
	public unsafe static double Invoke(void* x)
	{
		return fputil_getpayload_long_double.Invoke(*unchecked((double*)x));
	}
}
