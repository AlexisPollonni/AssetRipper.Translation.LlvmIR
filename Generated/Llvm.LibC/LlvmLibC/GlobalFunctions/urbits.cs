namespace LlvmLibC.GlobalFunctions;

internal static partial class urbits
{
	public unsafe static short Invoke(short x)
	{
		short num = x;
		return cpp_enable_if_sizeof_unsigned_Fract_sizeof_unsigned_short_cpp_is_trivially_constructible_unsigned_Fract_value_cpp_is_trivially_copyable_unsigned_Fract_value_cpp_is_trivially_copyable_unsigned_short_value_unsigned_Fract_type_cpp_bit_cast_unsigned_Fract_unsigned_short_unsigned_short_const.Invoke(&num);
	}
}
