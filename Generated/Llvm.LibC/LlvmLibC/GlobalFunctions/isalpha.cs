namespace LlvmLibC.GlobalFunctions;

internal static partial class isalpha
{
	public static int Invoke(int c)
	{
		return internal_isalpha_int.Invoke(c) ? 1 : 0;
	}
}
