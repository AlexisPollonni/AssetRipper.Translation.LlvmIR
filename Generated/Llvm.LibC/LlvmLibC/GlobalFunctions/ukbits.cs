namespace LlvmLibC.GlobalFunctions;

internal static partial class ukbits
{
	public unsafe static int Invoke(int x)
	{
		int num = x;
		return cpp_bit_cast_unsigned_Accum_unsigned_int.Invoke(&num);
	}
}
