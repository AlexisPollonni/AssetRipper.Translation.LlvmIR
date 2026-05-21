namespace LlvmLibC.GlobalFunctions;

internal static partial class setpayloadf
{
	public unsafe static int Invoke(void* res, float pl)
	{
		return fputil_setpayload_false_float.Invoke(res, pl) ? 1 : 0;
	}
}
