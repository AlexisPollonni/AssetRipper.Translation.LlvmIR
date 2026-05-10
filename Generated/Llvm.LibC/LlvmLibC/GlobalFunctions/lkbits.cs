namespace LlvmLibC.GlobalFunctions;

internal static partial class lkbits
{
	public unsafe static long Invoke(long x)
	{
		long num = x;
		return cpp_enable_if_sizeof_long_Accum_sizeof_long_long_cpp_is_trivially_constructible_long_Accum_value_cpp_is_trivially_copyable_long_Accum_value_cpp_is_trivially_copyable_long_long_value_long_Accum_type_cpp_bit_cast_long_Accum_long_long_long_long_const.Invoke(&num);
	}
}
