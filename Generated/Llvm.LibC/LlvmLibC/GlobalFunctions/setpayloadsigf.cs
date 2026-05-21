namespace LlvmLibC.GlobalFunctions;

internal static partial class setpayloadsigf
{
	public unsafe static int Invoke(void* res, float pl)
	{
		return fputil_setpayload_true_float.Invoke(res, pl) ? 1 : 0;
	}
}
