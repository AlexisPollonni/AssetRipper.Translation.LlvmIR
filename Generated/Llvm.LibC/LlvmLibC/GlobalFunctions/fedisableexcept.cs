namespace LlvmLibC.GlobalFunctions;

internal static partial class fedisableexcept
{
	public static int Invoke(int e)
	{
		return fputil_disable_except.Invoke(e);
	}
}
