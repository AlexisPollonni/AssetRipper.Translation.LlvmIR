namespace LlvmLibC.GlobalFunctions;

internal static partial class toascii
{
	public static int Invoke(int c)
	{
		return c & 0x7F;
	}
}
