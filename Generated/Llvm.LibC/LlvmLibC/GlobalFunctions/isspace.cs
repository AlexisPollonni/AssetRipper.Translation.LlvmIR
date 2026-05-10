namespace LlvmLibC.GlobalFunctions;

internal static partial class isspace
{
	public static int Invoke(int c)
	{
		return internal_isspace_int_224.Invoke(c) ? 1 : 0;
	}
}
