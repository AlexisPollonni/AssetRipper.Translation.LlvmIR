namespace LlvmLibC.GlobalFunctions;

internal static partial class urbits
{
	public unsafe static short Invoke(short x)
	{
		short num = x;
		return cpp_bit_cast_unsigned_Fract_unsigned_short.Invoke(&num);
	}
}
