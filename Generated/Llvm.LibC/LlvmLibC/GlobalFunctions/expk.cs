using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class expk
{
	public unsafe static int Invoke(int x)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int a = 0;
		int a2 = 0;
		int b = 0;
		int b2 = 0;
		unchecked
		{
			int result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(x >= 363408, expected: false))
			{
				result = fixed_point_FXRep_Accum_MAX.Invoke();
			}
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(x <= -363409, expected: false))
			{
				result = fixed_point_FXRep_Accum_ZERO.Invoke();
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = 1024;
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = x + 1024 >> 11 << 11;
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = x - num2;
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = num2 + 362496 >> 11;
				int num6 = cpp_enable_if_sizeof_unsigned_int_sizeof_Accum_cpp_is_trivially_constructible_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_cpp_is_trivially_copyable_Accum_value_unsigned_int_type_cpp_bit_cast_unsigned_int_Accum_Accum_const.Invoke(&num5);
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				num4 = num6;
				llvm_lifetime_start_p0.Invoke(4L, &a);
				long num7 = (uint)(num4 >>> 4);
				a = ((int*)anonymous_namespace_EXP_HI.Pointer)[num7];
				llvm_lifetime_start_p0.Invoke(4L, &a2);
				long num8 = (uint)(num4 & 0xF);
				a2 = ((int*)anonymous_namespace_EXP_MID.Pointer)[num8];
				llvm_lifetime_start_p0.Invoke(4L, &b);
				b = 32768 + (num3 >> 1);
				llvm_lifetime_start_p0.Invoke(4L, &b2);
				b2 = 32768 + llvm_smul_fix_i32.Invoke(num3, b, 15);
				result = llvm_smul_fix_i32.Invoke(a, llvm_smul_fix_i32.Invoke(a2, b2, 15), 15);
				llvm_lifetime_end_p0.Invoke(4L, &b2);
				llvm_lifetime_end_p0.Invoke(4L, &b);
				llvm_lifetime_end_p0.Invoke(4L, &a2);
				llvm_lifetime_end_p0.Invoke(4L, &a);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return result;
		}
	}
}
