namespace LlvmLibC.GlobalFunctions;

internal static partial class setpayloadl
{
	public unsafe static int Invoke(void* res, double pl)
	{
		return fputil_setpayload_false_long_double.Invoke(res, pl) ? 1 : 0;
	}
}
