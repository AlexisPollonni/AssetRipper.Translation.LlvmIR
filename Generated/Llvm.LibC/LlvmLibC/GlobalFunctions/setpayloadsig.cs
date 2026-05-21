namespace LlvmLibC.GlobalFunctions;

internal static partial class setpayloadsig
{
	public unsafe static int Invoke(void* res, double pl)
	{
		return fputil_setpayload_true_double.Invoke(res, pl) ? 1 : 0;
	}
}
