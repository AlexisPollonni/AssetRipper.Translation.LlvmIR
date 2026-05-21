namespace LlvmLibC.GlobalFunctions;

internal static partial class setpayloadsigf128
{
	public unsafe static int Invoke(void* res, double pl)
	{
		return fputil_setpayload_true_float128.Invoke(res, pl) ? 1 : 0;
	}
}
