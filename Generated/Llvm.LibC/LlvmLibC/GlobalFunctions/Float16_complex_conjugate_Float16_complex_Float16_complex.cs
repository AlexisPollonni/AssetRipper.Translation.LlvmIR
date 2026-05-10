using System;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9conjugateICDF16_EET_S2_")]
[DemangledName("_Float16 complex __llvm_libc_20_1_2_::conjugate<_Float16 complex>(_Float16 complex)")]
internal static partial class Float16_complex_conjugate_Float16_complex_Float16_complex
{
	public unsafe static InlineArray2_Half Invoke([MangledName("c.coerce")] InlineArray2_Half c)
	{
		Struct_zwcg27 struct_zwcg = default(Struct_zwcg27);
		Struct_zwcg27 struct_zwcg2 = default(Struct_zwcg27);
		Complex_ueqjqt complex_ueqjqt = default(Complex_ueqjqt);
		Struct_zwcg27 struct_zwcg3 = default(Struct_zwcg27);
		unchecked
		{
			*(InlineArray2_Half*)(&struct_zwcg2) = c;
			llvm_lifetime_start_p0.Invoke(4L, &complex_ueqjqt);
			*(Half*)(&complex_ueqjqt) = default(Half);
			*(Half*)((byte*)(&complex_ueqjqt) + 2) = default(Half);
			*(InlineArray2_Half*)(&complex_ueqjqt) = cpp_enable_if_sizeof_Complex_Float16_sizeof_Float16_complex_cpp_is_trivially_constructible_Complex_Float16_value_cpp_is_trivially_copyable_Complex_Float16_value_cpp_is_trivially_copyable_Float16_complex_value_Complex_Float16_type_cpp_bit_cast_Complex_Float16_Float16_complex_Float16_complex_const.Invoke(&struct_zwcg2);
			complex_ueqjqt.imag = (Half)(0f - (float)complex_ueqjqt.imag);
			*(InlineArray2_Half*)(&struct_zwcg3) = cpp_enable_if_sizeof_Float16_complex_sizeof_Complex_Float16_cpp_is_trivially_constructible_Float16_complex_value_cpp_is_trivially_copyable_Float16_complex_value_cpp_is_trivially_copyable_Complex_Float16_value_Float16_complex_type_cpp_bit_cast_Float16_complex_Complex_Float16_Complex_Float16_const.Invoke(&complex_ueqjqt);
			Half field_ = struct_zwcg3.field_0;
			Half field_2 = struct_zwcg3.field_1;
			Half* ptr = &struct_zwcg.field_1;
			struct_zwcg.field_0 = field_;
			*ptr = field_2;
			llvm_lifetime_end_p0.Invoke(4L, &complex_ueqjqt);
			return *(InlineArray2_Half*)(&struct_zwcg);
		}
	}
}
