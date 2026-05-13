using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point4sqrtIDRmEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned long _Fract>, unsigned long _Fract>::type __llvm_libc_20_1_2_::fixed_point::sqrt<unsigned long _Fract>(unsigned long _Fract)")]
internal static partial class cpp_enable_if_cpp_is_fixed_point_v_unsigned_long_Fract_unsigned_long_Fract_type_fixed_point_sqrt_unsigned_long_Fract_unsigned_long_Fract
{
	public unsafe static int Invoke(int x)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int x_frac = 0;
		int num7 = 0;
		int num8 = x;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = cpp_enable_if_sizeof_unsigned_int_sizeof_unsigned_long_Fract_cpp_is_trivially_constructible_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_cpp_is_trivially_copyable_unsigned_long_Fract_value_unsigned_int_type_cpp_bit_cast_unsigned_int_unsigned_long_Fract_unsigned_long_Fract_const.Invoke(&num8);
		int result;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num == 0, expected: false))
		{
			result = fixed_point_FXRep_unsigned_long_Fract_ZERO.Invoke();
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_countl_zero_unsigned_int_unsigned_int.Invoke(num);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 32;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = -1;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = -1 - num2;
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = -2 - (num5 & -2);
			num <<= num6;
			llvm_lifetime_start_p0.Invoke(4L, &x_frac);
			x_frac = cpp_enable_if_sizeof_unsigned_long_Fract_sizeof_unsigned_int_cpp_is_trivially_constructible_unsigned_long_Fract_value_cpp_is_trivially_copyable_unsigned_long_Fract_value_cpp_is_trivially_copyable_unsigned_int_value_unsigned_long_Fract_type_cpp_bit_cast_unsigned_long_Fract_unsigned_int_unsigned_int_const.Invoke(&num);
			llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = fixed_point_internal_SqrtConfig_unsigned_long_Fract_Type_fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_long_Fract_fixed_point_internal_SqrtConfig_unsigned_long_Fract_Type.Invoke(x_frac);
			num7 >>>= -1 - (num5 >> 1);
			result = cpp_enable_if_sizeof_unsigned_long_Fract_sizeof_unsigned_long_Fract_cpp_is_trivially_constructible_unsigned_long_Fract_value_cpp_is_trivially_copyable_unsigned_long_Fract_value_cpp_is_trivially_copyable_unsigned_long_Fract_value_unsigned_long_Fract_type_cpp_bit_cast_unsigned_long_Fract_unsigned_long_Fract_unsigned_long_Fract_const.Invoke(&num7);
			llvm_lifetime_end_p0.Invoke(4L, &num7);
			llvm_lifetime_end_p0.Invoke(4L, &x_frac);
			llvm_lifetime_end_p0.Invoke(4L, &num6);
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
