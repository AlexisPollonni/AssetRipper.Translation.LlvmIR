namespace LlvmLibC.GlobalFunctions;

internal static partial class hkbits
{
	public unsafe static short Invoke(short x)
	{
		short num = x;
		return cpp_bit_cast_short_Accum_short.Invoke(&num);
	}
}
