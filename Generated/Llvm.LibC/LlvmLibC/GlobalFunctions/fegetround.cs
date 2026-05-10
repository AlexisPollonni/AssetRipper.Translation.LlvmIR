namespace LlvmLibC.GlobalFunctions;

internal static partial class fegetround
{
	public static int Invoke()
	{
		return fputil_get_round.Invoke();
	}
}
