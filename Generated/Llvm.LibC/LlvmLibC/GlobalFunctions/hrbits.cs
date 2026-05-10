namespace LlvmLibC.GlobalFunctions;

internal static partial class hrbits
{
	public unsafe static sbyte Invoke(sbyte x)
	{
		sbyte b = x;
		return cpp_enable_if_sizeof_short_Fract_sizeof_signed_char_cpp_is_trivially_constructible_short_Fract_value_cpp_is_trivially_copyable_short_Fract_value_cpp_is_trivially_copyable_signed_char_value_short_Fract_type_cpp_bit_cast_short_Fract_signed_char_signed_char_const.Invoke(&b);
	}
}
