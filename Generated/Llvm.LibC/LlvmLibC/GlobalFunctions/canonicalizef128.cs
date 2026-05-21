namespace LlvmLibC.GlobalFunctions;

internal static partial class canonicalizef128
{
	public unsafe static int Invoke(void* cx, void* x)
	{
		return fputil_canonicalize_float128_0.Invoke(cx, x);
	}
}
