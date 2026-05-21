namespace LlvmLibC.GlobalFunctions;

internal static partial class canonicalizef16
{
	public unsafe static int Invoke(void* cx, void* x)
	{
		return fputil_canonicalize_Float16_0.Invoke(cx, x);
	}
}
