using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cimagl
{
	public unsafe static double Invoke(void* x)
	{
		Complex_p54sq8 complex_p54sq = default(Complex_p54sq8);
		llvm_lifetime_start_p0.Invoke(32L, &complex_p54sq);
		unchecked
		{
			*(double*)(&complex_p54sq) = double.NaN;
			((double*)(&complex_p54sq))[2] = double.NaN;
			cpp_enable_if_sizeof_Complex_long_double_sizeof_long_double_complex_cpp_is_trivially_constructible_Complex_long_double_value_cpp_is_trivially_copyable_Complex_long_double_value_cpp_is_trivially_copyable_long_double_complex_value_Complex_long_double_type_cpp_bit_cast_Complex_long_double_long_double_complex_long_double_complex_const.Invoke(&complex_p54sq, x);
			double imag = complex_p54sq.imag;
			llvm_lifetime_end_p0.Invoke(32L, &complex_p54sq);
			return imag;
		}
	}
}
