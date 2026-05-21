namespace LlvmLibC.GlobalFunctions;

internal static partial class canonicalizef
{
	public unsafe static int Invoke(void* cx, void* x)
	{
		return fputil_canonicalize_float_0.Invoke(cx, x);
	}
}
