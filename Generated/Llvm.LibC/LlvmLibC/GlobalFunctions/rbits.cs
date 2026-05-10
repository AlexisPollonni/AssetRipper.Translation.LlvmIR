namespace LlvmLibC.GlobalFunctions;

internal static partial class rbits
{
	public unsafe static short Invoke(short x)
	{
		short num = x;
		return cpp_enable_if_sizeof_Fract_sizeof_short_cpp_is_trivially_constructible_Fract_value_cpp_is_trivially_copyable_Fract_value_cpp_is_trivially_copyable_short_value_Fract_type_cpp_bit_cast_Fract_short_short_const.Invoke(&num);
	}
}
