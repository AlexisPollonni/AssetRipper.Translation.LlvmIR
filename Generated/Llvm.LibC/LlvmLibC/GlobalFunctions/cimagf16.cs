using System;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cimagf16
{
	public unsafe static Half Invoke([MangledName("x.coerce")] InlineArray2_Half x)
	{
		Struct_zwcg27 struct_zwcg = default(Struct_zwcg27);
		Complex_ueqjqt complex_ueqjqt = default(Complex_ueqjqt);
		unchecked
		{
			*(InlineArray2_Half*)(&struct_zwcg) = x;
			llvm_lifetime_start_p0.Invoke(4L, &complex_ueqjqt);
			*(Half*)(&complex_ueqjqt) = default(Half);
			*(Half*)((byte*)(&complex_ueqjqt) + 2) = default(Half);
			*(InlineArray2_Half*)(&complex_ueqjqt) = cpp_enable_if_sizeof_Complex_Float16_sizeof_Float16_complex_cpp_is_trivially_constructible_Complex_Float16_value_cpp_is_trivially_copyable_Complex_Float16_value_cpp_is_trivially_copyable_Float16_complex_value_Complex_Float16_type_cpp_bit_cast_Complex_Float16_Float16_complex_Float16_complex_const.Invoke(&struct_zwcg);
			Half imag = complex_ueqjqt.imag;
			llvm_lifetime_end_p0.Invoke(4L, &complex_ueqjqt);
			return imag;
		}
	}
}
