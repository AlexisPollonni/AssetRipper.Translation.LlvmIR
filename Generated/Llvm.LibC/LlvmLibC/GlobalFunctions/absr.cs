namespace LlvmLibC.GlobalFunctions;

internal static partial class absr
{
	public static short Invoke(short x)
	{
		return fixed_point_abs_Fract.Invoke(x);
	}
}
