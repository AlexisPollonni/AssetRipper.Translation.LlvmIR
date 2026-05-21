namespace LlvmLibC.GlobalFunctions;

internal static partial class uksqrtui
{
	public static int Invoke(int x)
	{
		return fixed_point_isqrt_unsigned_int.Invoke(x);
	}
}
