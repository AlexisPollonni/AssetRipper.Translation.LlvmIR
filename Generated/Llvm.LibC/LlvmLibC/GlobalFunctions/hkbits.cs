namespace LlvmLibC.GlobalFunctions;

internal static partial class hkbits
{
	public unsafe static short Invoke(short x)
	{
		short num = x;
		return cpp_enable_if_sizeof_short_Accum_sizeof_short_cpp_is_trivially_constructible_short_Accum_value_cpp_is_trivially_copyable_short_Accum_value_cpp_is_trivially_copyable_short_value_short_Accum_type_cpp_bit_cast_short_Accum_short_short_const.Invoke(&num);
	}
}
