namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrtur
{
	public static short Invoke(short x)
	{
		return fixed_point_sqrt_unsigned_Fract.Invoke(x);
	}
}
