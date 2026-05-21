namespace LlvmLibC.GlobalFunctions;

internal static partial class getpayloadf128
{
	public unsafe static double Invoke(void* x)
	{
		return fputil_getpayload_float128.Invoke(*unchecked((double*)x));
	}
}
