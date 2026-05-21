namespace LlvmLibC.GlobalFunctions;

internal static partial class rbits
{
	public unsafe static short Invoke(short x)
	{
		short num = x;
		return cpp_bit_cast_Fract_short.Invoke(&num);
	}
}
