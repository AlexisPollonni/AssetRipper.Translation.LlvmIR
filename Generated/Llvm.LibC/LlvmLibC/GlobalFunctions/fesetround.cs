namespace LlvmLibC.GlobalFunctions;

internal static partial class fesetround
{
	public static int Invoke(int m)
	{
		return fputil_set_round_int.Invoke(m);
	}
}
