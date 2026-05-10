namespace LlvmLibC.GlobalFunctions;

internal static partial class frexpf
{
	public unsafe static float Invoke(float x, void* exp)
	{
		return float_fputil_frexp_float_0_float_int.Invoke(x, exp);
	}
}
