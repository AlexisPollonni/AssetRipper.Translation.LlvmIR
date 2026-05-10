namespace LlvmLibC.GlobalFunctions;

internal static partial class ukbits
{
	public unsafe static int Invoke(int x)
	{
		int num = x;
		return cpp_enable_if_sizeof_unsigned_Accum_sizeof_unsigned_int_cpp_is_trivially_constructible_unsigned_Accum_value_cpp_is_trivially_copyable_unsigned_Accum_value_cpp_is_trivially_copyable_unsigned_int_value_unsigned_Accum_type_cpp_bit_cast_unsigned_Accum_unsigned_int_unsigned_int_const.Invoke(&num);
	}
}
