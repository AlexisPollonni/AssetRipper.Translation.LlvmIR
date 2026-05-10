namespace LlvmLibC.GlobalFunctions;

internal static partial class canonicalizef
{
	public unsafe static int Invoke(void* cx, void* x)
	{
		return int_fputil_canonicalize_float_0_float_float_const.Invoke(cx, x);
	}
}
