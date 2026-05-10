namespace LlvmLibC.GlobalFunctions;

internal static partial class issignalingf
{
	public unsafe static int Invoke(float x)
	{
		float num = x;
		return int_fputil_issignaling_impl_float_0_float_const.Invoke(&num);
	}
}
