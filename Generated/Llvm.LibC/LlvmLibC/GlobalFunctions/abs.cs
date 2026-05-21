namespace LlvmLibC.GlobalFunctions;

internal static partial class abs
{
	public static int Invoke(int n)
	{
		return integer_abs_int.Invoke(n);
	}
}
