namespace LlvmLibC.GlobalFunctions;

internal static partial class getpayloadf
{
	public unsafe static float Invoke(void* x)
	{
		return fputil_getpayload_float.Invoke(*unchecked((float*)x));
	}
}
