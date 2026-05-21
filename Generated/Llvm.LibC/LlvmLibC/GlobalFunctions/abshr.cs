namespace LlvmLibC.GlobalFunctions;

internal static partial class abshr
{
	public static sbyte Invoke(sbyte x)
	{
		return fixed_point_abs_short_Fract.Invoke(x);
	}
}
