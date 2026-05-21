namespace LlvmLibC.GlobalFunctions;

internal static partial class isdigit
{
	public static int Invoke(int c)
	{
		return internal_isdigit_xdnave.Invoke(c) ? 1 : 0;
	}
}
