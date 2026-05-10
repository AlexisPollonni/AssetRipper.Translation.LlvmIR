using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5roundIDRsEET_S2_i")]
[DemangledName("short _Fract __llvm_libc_20_1_2_::fixed_point::round<short _Fract>(short _Fract, int)")]
internal static partial class short_Fract_fixed_point_round_short_Fract_short_Fract_int
{
	public unsafe static sbyte Invoke(sbyte x, int n)
	{
		sbyte b = 0;
		sbyte b2 = 0;
		int num = 0;
		sbyte y = 0;
		sbyte b3 = x;
		int num2 = n;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 < 0, expected: false))
		{
			num2 = 0;
		}
		unchecked
		{
			sbyte result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 >= 7, expected: false))
			{
				result = b3;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (sbyte)(fixed_point_FXRep_short_Fract_EPS.Invoke() << (int)(sbyte)checked(7 - num2 - 1));
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(fixed_point_FXRep_short_Fract_MAX.Invoke() - b < b3, expected: false))
				{
					result = fixed_point_FXRep_short_Fract_MAX.Invoke();
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					b2 = cpp_enable_if_cpp_is_fixed_point_v_short_Fract_short_Fract_type_fixed_point_bit_not_short_Fract_short_Fract.Invoke(fixed_point_FXRep_short_Fract_ZERO.Invoke());
					llvm_lifetime_start_p0.Invoke(4L, &num);
					num = checked(7 - num2);
					llvm_lifetime_start_p0.Invoke(1L, &y);
					y = (sbyte)((num != 8) ? (b2 << (int)(sbyte)num) : fixed_point_FXRep_short_Fract_ZERO.Invoke());
					result = cpp_enable_if_cpp_is_fixed_point_v_short_Fract_short_Fract_type_fixed_point_bit_and_short_Fract_short_Fract_short_Fract.Invoke((sbyte)(b3 + b), y);
					llvm_lifetime_end_p0.Invoke(1L, &y);
					llvm_lifetime_end_p0.Invoke(4L, &num);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
				}
				llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			return result;
		}
	}
}
