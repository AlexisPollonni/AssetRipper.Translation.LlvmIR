namespace LlvmLibC.GlobalFunctions;

internal static partial class kbits
{
	public unsafe static int Invoke(int x)
	{
		int num = x;
		return cpp_enable_if_sizeof_Accum_sizeof_int_cpp_is_trivially_constructible_Accum_value_cpp_is_trivially_copyable_Accum_value_cpp_is_trivially_copyable_int_value_Accum_type_cpp_bit_cast_Accum_int_int_const.Invoke(&num);
	}
}
