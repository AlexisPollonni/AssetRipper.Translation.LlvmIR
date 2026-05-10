namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrtuk
{
	public static int Invoke(int x)
	{
		return cpp_enable_if_cpp_is_fixed_point_v_unsigned_Accum_unsigned_Accum_type_fixed_point_sqrt_unsigned_Accum_unsigned_Accum.Invoke(x);
	}
}
