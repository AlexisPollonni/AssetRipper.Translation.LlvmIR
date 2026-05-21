namespace LlvmLibC.GlobalFunctions;

internal static partial class frexpf
{
	public unsafe static float Invoke(float x, void* exp)
	{
		return fputil_frexp_float_0.Invoke(x, exp);
	}
}
