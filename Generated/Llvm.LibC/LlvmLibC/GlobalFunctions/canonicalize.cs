namespace LlvmLibC.GlobalFunctions;

internal static partial class canonicalize
{
	public unsafe static int Invoke(void* cx, void* x)
	{
		return fputil_canonicalize_double_0.Invoke(cx, x);
	}
}
