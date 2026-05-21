namespace LlvmLibC.GlobalFunctions;

internal static partial class fesetround
{
	public static int Invoke(int m)
	{
		return fputil_set_round.Invoke(m);
	}
}
