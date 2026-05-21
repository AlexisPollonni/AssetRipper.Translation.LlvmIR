namespace LlvmLibC.GlobalFunctions;

internal static partial class kbits
{
	public unsafe static int Invoke(int x)
	{
		int num = x;
		return cpp_bit_cast_Accum_int.Invoke(&num);
	}
}
