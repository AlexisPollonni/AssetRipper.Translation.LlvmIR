using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class exphk
{
	public unsafe static short Invoke(short x)
	{
		short num = 0;
		short num2 = 0;
		short num3 = 0;
		short num4 = 0;
		short num5 = 0;
		short parameter_ = 0;
		short parameter_2 = 0;
		short num6 = x;
		unchecked
		{
			short result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num6 >= 712, expected: false))
			{
				result = fixed_point_FXRep_short_Accum_MAX.Invoke();
			}
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num6 <= -710, expected: false))
			{
				result = fixed_point_FXRep_short_Accum_ZERO.Invoke();
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(2L, &num);
				num = 8;
				llvm_lifetime_start_p0.Invoke(2L, &num2);
				num2 = (short)(num6 + 8 >> 4 << 4);
				llvm_lifetime_start_p0.Invoke(2L, &num3);
				num3 = (short)(num6 - num2);
				llvm_lifetime_start_p0.Invoke(2L, &num4);
				llvm_lifetime_start_p0.Invoke(2L, &num5);
				num5 = (short)(num2 + 704 >> 4);
				short num7 = cpp_enable_if_sizeof_unsigned_short_sizeof_short_Accum_cpp_is_trivially_constructible_unsigned_short_value_cpp_is_trivially_copyable_unsigned_short_value_cpp_is_trivially_copyable_short_Accum_value_unsigned_short_type_cpp_bit_cast_unsigned_short_short_Accum_short_Accum_const.Invoke(&num5);
				llvm_lifetime_end_p0.Invoke(2L, &num5);
				num4 = num7;
				llvm_lifetime_start_p0.Invoke(2L, &parameter_);
				long num8 = (ushort)num4 >> 3;
				parameter_ = ((short*)anonymous_namespace_EXP_HI_1.Pointer)[num8];
				llvm_lifetime_start_p0.Invoke(2L, &parameter_2);
				long num9 = (ushort)num4 & 7;
				parameter_2 = ((short*)anonymous_namespace_EXP_MID_2.Pointer)[num9];
				result = llvm_smul_fix_i16.Invoke(parameter_, llvm_smul_fix_i16.Invoke(parameter_2, (short)(128 + num3), 7), 7);
				llvm_lifetime_end_p0.Invoke(2L, &parameter_2);
				llvm_lifetime_end_p0.Invoke(2L, &parameter_);
				llvm_lifetime_end_p0.Invoke(2L, &num4);
				llvm_lifetime_end_p0.Invoke(2L, &num3);
				llvm_lifetime_end_p0.Invoke(2L, &num2);
				llvm_lifetime_end_p0.Invoke(2L, &num);
			}
			return result;
		}
	}
}
