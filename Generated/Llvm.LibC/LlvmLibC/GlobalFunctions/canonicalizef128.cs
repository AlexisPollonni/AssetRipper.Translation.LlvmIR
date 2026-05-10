namespace LlvmLibC.GlobalFunctions;

internal static partial class canonicalizef128
{
	public unsafe static int Invoke(void* cx, void* x)
	{
		return int_fputil_canonicalize_float128_0_float128_float128_const.Invoke(cx, x);
	}
}
