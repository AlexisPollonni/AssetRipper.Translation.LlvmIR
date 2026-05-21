namespace LlvmLibC.GlobalFunctions;

internal static partial class setpayload
{
	public unsafe static int Invoke(void* res, double pl)
	{
		return fputil_setpayload_false_double.Invoke(res, pl) ? 1 : 0;
	}
}
