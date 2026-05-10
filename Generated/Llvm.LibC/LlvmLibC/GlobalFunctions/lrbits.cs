namespace LlvmLibC.GlobalFunctions;

internal static partial class lrbits
{
	public unsafe static int Invoke(int x)
	{
		int num = x;
		return cpp_enable_if_sizeof_long_Fract_sizeof_int_cpp_is_trivially_constructible_long_Fract_value_cpp_is_trivially_copyable_long_Fract_value_cpp_is_trivially_copyable_int_value_long_Fract_type_cpp_bit_cast_long_Fract_int_int_const.Invoke(&num);
	}
}
