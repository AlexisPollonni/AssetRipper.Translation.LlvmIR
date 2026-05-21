namespace LlvmLibC.GlobalFunctions;

internal static partial class isspace
{
	public static int Invoke(int c)
	{
		return internal_isspace_gyrrf5.Invoke(c) ? 1 : 0;
	}
}
