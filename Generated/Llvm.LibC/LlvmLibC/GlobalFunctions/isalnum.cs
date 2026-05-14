namespace LlvmLibC.GlobalFunctions;

internal static partial class isalnum
{
	public static int Invoke(int c)
	{
		return internal_isalnum_int_231.Invoke(c) ? 1 : 0;
	}
}
