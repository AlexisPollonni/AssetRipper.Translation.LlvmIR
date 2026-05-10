namespace LlvmLibC.GlobalFunctions;

internal static partial class fedisableexcept
{
	public static int Invoke(int e)
	{
		return fputil_disable_except_int.Invoke(e);
	}
}
