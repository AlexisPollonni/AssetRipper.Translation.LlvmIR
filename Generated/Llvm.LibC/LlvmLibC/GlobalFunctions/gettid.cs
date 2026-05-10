namespace LlvmLibC.GlobalFunctions;

internal static partial class gettid
{
	public static int Invoke()
	{
		return internal_gettid.Invoke();
	}
}
