namespace LlvmLibC.GlobalFunctions;

internal static partial class canonicalizef16
{
	public unsafe static int Invoke(void* cx, void* x)
	{
		return int_fputil_canonicalize_Float16_0_Float16_Float16_const.Invoke(cx, x);
	}
}
