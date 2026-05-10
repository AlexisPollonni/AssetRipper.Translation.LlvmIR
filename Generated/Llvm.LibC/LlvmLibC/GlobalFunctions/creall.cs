using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class creall
{
	public unsafe static double Invoke(void* x)
	{
		Complex_wk9una complex_wk9una = default(Complex_wk9una);
		llvm_lifetime_start_p0.Invoke(32L, &complex_wk9una);
		unchecked
		{
			*(double*)(&complex_wk9una) = double.NaN;
			((double*)(&complex_wk9una))[2] = double.NaN;
			cpp_enable_if_sizeof_Complex_long_double_sizeof_long_double_complex_cpp_is_trivially_constructible_Complex_long_double_value_cpp_is_trivially_copyable_Complex_long_double_value_cpp_is_trivially_copyable_long_double_complex_value_Complex_long_double_type_cpp_bit_cast_Complex_long_double_long_double_complex_long_double_complex_const.Invoke(&complex_wk9una, x);
			double real = complex_wk9una.real;
			llvm_lifetime_end_p0.Invoke(32L, &complex_wk9una);
			return real;
		}
	}
}
