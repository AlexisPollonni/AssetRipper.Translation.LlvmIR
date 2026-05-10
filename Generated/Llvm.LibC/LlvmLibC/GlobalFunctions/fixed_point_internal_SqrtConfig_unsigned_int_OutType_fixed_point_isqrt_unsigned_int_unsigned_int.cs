using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5isqrtIjEENS0_8internal10SqrtConfigIT_E7OutTypeES4_")]
[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned int>::OutType __llvm_libc_20_1_2_::fixed_point::isqrt<unsigned int>(unsigned int)")]
internal static partial class fixed_point_internal_SqrtConfig_unsigned_int_OutType_fixed_point_isqrt_unsigned_int_unsigned_int
{
	public unsafe static int Invoke(int x)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int x_frac = 0;
		int num4 = 0;
		num = x;
		int result;
		if (num == 0)
		{
			result = fixed_point_FXRep_unsigned_Accum_ZERO.Invoke();
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_countl_zero_unsigned_int_unsigned_int.Invoke(num);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = num2 >> 1 << 1;
			num <<= num3;
			llvm_lifetime_start_p0.Invoke(4L, &x_frac);
			x_frac = cpp_enable_if_sizeof_unsigned_long_Fract_sizeof_unsigned_int_cpp_is_trivially_constructible_unsigned_long_Fract_value_cpp_is_trivially_copyable_unsigned_long_Fract_value_cpp_is_trivially_copyable_unsigned_int_value_unsigned_long_Fract_type_cpp_bit_cast_unsigned_long_Fract_unsigned_int_unsigned_int_const.Invoke(&num);
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = fixed_point_internal_SqrtConfig_unsigned_long_Fract_Type_fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_long_Fract_fixed_point_internal_SqrtConfig_unsigned_long_Fract_Type.Invoke(x_frac);
			num4 >>>= num3 >> 1;
			result = cpp_enable_if_sizeof_unsigned_Accum_sizeof_unsigned_long_Fract_cpp_is_trivially_constructible_unsigned_Accum_value_cpp_is_trivially_copyable_unsigned_Accum_value_cpp_is_trivially_copyable_unsigned_long_Fract_value_unsigned_Accum_type_cpp_bit_cast_unsigned_Accum_unsigned_long_Fract_unsigned_long_Fract_const.Invoke(&num4);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &x_frac);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
		}
		return result;
	}
}
