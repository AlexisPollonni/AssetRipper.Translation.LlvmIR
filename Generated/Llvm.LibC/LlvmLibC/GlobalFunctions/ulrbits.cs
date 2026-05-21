namespace LlvmLibC.GlobalFunctions;

internal static partial class ulrbits
{
	public unsafe static int Invoke(int x)
	{
		int num = x;
		return cpp_bit_cast_unsigned_long_Fract_unsigned_int.Invoke(&num);
	}
}
