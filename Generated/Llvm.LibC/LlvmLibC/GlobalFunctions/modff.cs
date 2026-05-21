namespace LlvmLibC.GlobalFunctions;

internal static partial class modff
{
	public unsafe static float Invoke(float x, void* iptr)
	{
		return fputil_modf_float_0.Invoke(x, iptr);
	}
}
