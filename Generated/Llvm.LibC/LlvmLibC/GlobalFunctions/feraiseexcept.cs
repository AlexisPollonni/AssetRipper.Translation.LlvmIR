namespace LlvmLibC.GlobalFunctions;

internal static partial class feraiseexcept
{
	public static int Invoke(int e)
	{
		return fputil_raise_except_int.Invoke(e);
	}
}
