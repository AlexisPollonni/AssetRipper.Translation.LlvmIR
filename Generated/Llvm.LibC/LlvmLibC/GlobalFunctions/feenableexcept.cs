namespace LlvmLibC.GlobalFunctions;

internal static partial class feenableexcept
{
	public static int Invoke(int e)
	{
		return fputil_enable_except_int.Invoke(e);
	}
}
