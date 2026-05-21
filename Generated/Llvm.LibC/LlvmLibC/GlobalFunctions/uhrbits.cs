namespace LlvmLibC.GlobalFunctions;

internal static partial class uhrbits
{
	public unsafe static sbyte Invoke(sbyte x)
	{
		sbyte b = x;
		return cpp_bit_cast_unsigned_short_Fract_unsigned_char.Invoke(&b);
	}
}
