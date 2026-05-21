namespace LlvmLibC.GlobalFunctions;

internal static partial class fetestexcept
{
	public static int Invoke(int e)
	{
		return fputil_test_except.Invoke(e);
	}
}
