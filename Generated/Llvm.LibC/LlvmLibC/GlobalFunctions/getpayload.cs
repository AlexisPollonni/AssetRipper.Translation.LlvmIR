namespace LlvmLibC.GlobalFunctions;

internal static partial class getpayload
{
	public unsafe static double Invoke(void* x)
	{
		return fputil_getpayload_double.Invoke(*unchecked((double*)x));
	}
}
