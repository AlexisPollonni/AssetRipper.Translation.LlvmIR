namespace LlvmLibC.GlobalFunctions;

internal static partial class isascii
{
	public static int Invoke(int c)
	{
		return ((c & -128) == 0) ? 1 : 0;
	}
}
