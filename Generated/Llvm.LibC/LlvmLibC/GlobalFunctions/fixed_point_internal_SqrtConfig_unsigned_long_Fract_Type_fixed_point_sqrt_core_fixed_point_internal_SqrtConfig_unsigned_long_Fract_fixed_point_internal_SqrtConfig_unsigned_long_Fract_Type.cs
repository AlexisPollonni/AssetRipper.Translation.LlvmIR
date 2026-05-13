using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point9sqrt_coreINS0_8internal10SqrtConfigIDRmEEEENT_4TypeES6_")]
[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned long _Fract>::Type __llvm_libc_20_1_2_::fixed_point::sqrt_core<__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned long _Fract>>(__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned long _Fract>::Type)")]
internal static partial class fixed_point_internal_SqrtConfig_unsigned_long_Fract_Type_fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_long_Fract_fixed_point_internal_SqrtConfig_unsigned_long_Fract_Type
{
	public unsafe static int Invoke(int x_frac)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int parameter_ = 0;
		int num4 = 0;
		int num5 = 0;
		int i = 0;
		num = x_frac;
		int result;
		if (num == fixed_point_FXRep_unsigned_long_Fract_ONE_FOURTH.Invoke())
		{
			result = fixed_point_FXRep_unsigned_long_Fract_ONE_HALF.Invoke();
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = cpp_enable_if_sizeof_unsigned_int_sizeof_unsigned_long_Fract_cpp_is_trivially_constructible_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_cpp_is_trivially_copyable_unsigned_long_Fract_value_unsigned_int_type_cpp_bit_cast_unsigned_int_unsigned_long_Fract_unsigned_long_Fract_const.Invoke(&num);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (num2 >>> 28) - 4;
			llvm_lifetime_start_p0.Invoke(4L, &parameter_);
			long num6 = num3;
			unchecked
			{
				parameter_ = *(int*)((byte*)fixed_point_internal_SqrtConfig_unsigned_long_Fract_FIRST_APPROX.Pointer + (nint)num6 * sizeof(InlineArray2_Int32));
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				long num7 = num3;
				num4 = ((int*)((byte*)fixed_point_internal_SqrtConfig_unsigned_long_Fract_FIRST_APPROX.Pointer + (nint)num7 * sizeof(InlineArray2_Int32)))[1];
				llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = llvm_umul_fix_i32.Invoke(parameter_, num, 32) + num4;
				llvm_lifetime_start_p0.Invoke(4L, &i);
				for (i = 0; i < 2; i = checked(i + 1))
				{
					num5 = (num5 >>> 1) + llvm_udiv_fix_i32.Invoke(num >>> 1, num5, 32);
				}
				llvm_lifetime_end_p0.Invoke(4L, &i);
				result = num5;
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &parameter_);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
		}
		return result;
	}
}
