namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrtuhr
{
	public static sbyte Invoke(sbyte x)
	{
		return fixed_point_sqrt_unsigned_short_Fract.Invoke(x);
	}
}
