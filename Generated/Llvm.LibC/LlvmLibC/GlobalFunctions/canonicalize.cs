namespace LlvmLibC.GlobalFunctions;

internal static partial class canonicalize
{
	public unsafe static int Invoke(void* cx, void* x)
	{
		return int_fputil_canonicalize_double_0_double_double_const.Invoke(cx, x);
	}
}
