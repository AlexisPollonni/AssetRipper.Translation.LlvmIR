namespace LlvmLibC.GlobalFunctions;

internal static partial class uhkbits
{
	public unsafe static short Invoke(short x)
	{
		short num = x;
		return cpp_bit_cast_unsigned_short_Accum_unsigned_short.Invoke(&num);
	}
}
