namespace LlvmLibC.GlobalFunctions;

internal static partial class fesetexcept
{
	public static int Invoke(int excepts)
	{
		return fputil_set_except_int.Invoke(excepts);
	}
}
