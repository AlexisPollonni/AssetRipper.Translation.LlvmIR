namespace LlvmLibC.GlobalFunctions;

internal static partial class lrbits
{
	public unsafe static int Invoke(int x)
	{
		int num = x;
		return cpp_bit_cast_long_Fract_int.Invoke(&num);
	}
}
