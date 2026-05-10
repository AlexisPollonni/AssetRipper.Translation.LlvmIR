namespace LlvmLibC.GlobalFunctions;

internal static partial class isblank
{
	public static int Invoke(int c)
	{
		return unchecked((byte)((c != 32) ? ((c == 9) ? 1 : 0) : (-1)));
	}
}
