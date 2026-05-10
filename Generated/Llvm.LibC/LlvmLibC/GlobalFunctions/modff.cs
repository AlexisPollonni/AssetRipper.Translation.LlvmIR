namespace LlvmLibC.GlobalFunctions;

internal static partial class modff
{
	public unsafe static float Invoke(float x, void* iptr)
	{
		return float_fputil_modf_float_0_float_float.Invoke(x, iptr);
	}
}
