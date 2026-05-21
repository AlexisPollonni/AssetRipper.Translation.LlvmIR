namespace LlvmLibC.GlobalFunctions;

internal static partial class issignalingf
{
	public unsafe static int Invoke(float x)
	{
		float num = x;
		return fputil_issignaling_impl_float_0.Invoke(&num);
	}
}
