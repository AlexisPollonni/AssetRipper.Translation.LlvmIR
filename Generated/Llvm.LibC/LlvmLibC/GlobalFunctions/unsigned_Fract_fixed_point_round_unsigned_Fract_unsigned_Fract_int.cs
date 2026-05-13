using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5roundIDRjEET_S2_i")]
[DemangledName("unsigned _Fract __llvm_libc_20_1_2_::fixed_point::round<unsigned _Fract>(unsigned _Fract, int)")]
internal static partial class unsigned_Fract_fixed_point_round_unsigned_Fract_unsigned_Fract_int
{
	public unsafe static short Invoke(short x, int n)
	{
		short num = 0;
		short num2 = 0;
		int num3 = 0;
		short y = 0;
		short num4 = x;
		int num5 = n;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num5 < 0, expected: false))
		{
			num5 = 0;
		}
		unchecked
		{
			short result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num5 >= 16, expected: false))
			{
				result = num4;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(2L, &num);
				num = (short)(fixed_point_FXRep_unsigned_Fract_EPS.Invoke() << (int)(short)checked(16 - num5 - 1));
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)(fixed_point_FXRep_unsigned_Fract_MAX.Invoke() - num) < (uint)num4, expected: false))
				{
					result = fixed_point_FXRep_unsigned_Fract_MAX.Invoke();
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &num2);
					num2 = cpp_enable_if_cpp_is_fixed_point_v_unsigned_Fract_unsigned_Fract_type_fixed_point_bit_not_unsigned_Fract_unsigned_Fract.Invoke(fixed_point_FXRep_unsigned_Fract_ZERO.Invoke());
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = checked(16 - num5);
					llvm_lifetime_start_p0.Invoke(2L, &y);
					y = (short)((num3 != 16) ? (num2 << (int)(short)num3) : fixed_point_FXRep_unsigned_Fract_ZERO.Invoke());
					result = cpp_enable_if_cpp_is_fixed_point_v_unsigned_Fract_unsigned_Fract_type_fixed_point_bit_and_unsigned_Fract_unsigned_Fract_unsigned_Fract.Invoke((short)(num4 + num), y);
					llvm_lifetime_end_p0.Invoke(2L, &y);
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					llvm_lifetime_end_p0.Invoke(2L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(2L, &num);
			}
			return result;
		}
	}
}
