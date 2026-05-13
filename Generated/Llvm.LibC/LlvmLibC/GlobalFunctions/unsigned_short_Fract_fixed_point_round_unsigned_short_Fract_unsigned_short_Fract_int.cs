using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5roundIDRtEET_S2_i")]
[DemangledName("unsigned short _Fract __llvm_libc_20_1_2_::fixed_point::round<unsigned short _Fract>(unsigned short _Fract, int)")]
internal static partial class unsigned_short_Fract_fixed_point_round_unsigned_short_Fract_unsigned_short_Fract_int
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
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 >= 8, expected: false))
			{
				result = b3;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (sbyte)(fixed_point_FXRep_unsigned_short_Fract_EPS.Invoke() << (int)(sbyte)checked(8 - num2 - 1));
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)(fixed_point_FXRep_unsigned_short_Fract_MAX.Invoke() - b) < (uint)b3, expected: false))
				{
					result = fixed_point_FXRep_unsigned_short_Fract_MAX.Invoke();
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					b2 = cpp_enable_if_cpp_is_fixed_point_v_unsigned_short_Fract_unsigned_short_Fract_type_fixed_point_bit_not_unsigned_short_Fract_unsigned_short_Fract.Invoke(fixed_point_FXRep_unsigned_short_Fract_ZERO.Invoke());
					llvm_lifetime_start_p0.Invoke(4L, &num);
					num = checked(8 - num2);
					llvm_lifetime_start_p0.Invoke(1L, &y);
					y = (sbyte)((num != 8) ? (b2 << (int)(sbyte)num) : fixed_point_FXRep_unsigned_short_Fract_ZERO.Invoke());
					result = cpp_enable_if_cpp_is_fixed_point_v_unsigned_short_Fract_unsigned_short_Fract_type_fixed_point_bit_and_unsigned_short_Fract_unsigned_short_Fract_unsigned_short_Fract.Invoke((sbyte)(b3 + b), y);
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
