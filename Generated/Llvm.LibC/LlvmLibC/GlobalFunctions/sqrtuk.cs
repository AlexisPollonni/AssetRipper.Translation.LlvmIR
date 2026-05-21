namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrtuk
{
	public static int Invoke(int x)
	{
		return fixed_point_sqrt_unsigned_Accum.Invoke(x);
	}
}
