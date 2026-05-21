namespace LlvmLibC.GlobalFunctions;

internal static partial class hrbits
{
	public unsafe static sbyte Invoke(sbyte x)
	{
		sbyte b = x;
		return cpp_bit_cast_short_Fract_signed_char.Invoke(&b);
	}
}
