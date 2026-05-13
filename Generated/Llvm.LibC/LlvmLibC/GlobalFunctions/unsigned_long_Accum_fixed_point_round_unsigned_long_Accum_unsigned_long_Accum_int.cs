using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5roundIDAmEET_S2_i")]
[DemangledName("unsigned long _Accum __llvm_libc_20_1_2_::fixed_point::round<unsigned long _Accum>(unsigned long _Accum, int)")]
internal static partial class unsigned_long_Accum_fixed_point_round_unsigned_long_Accum_unsigned_long_Accum_int
{
	public unsafe static long Invoke(long x, int n)
	{
		long num = 0L;
		long num2 = 0L;
		int num3 = 0;
		long y = 0L;
		int num4 = n;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num4 < 0, expected: false))
		{
			num4 = 0;
		}
		unchecked
		{
			long result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num4 >= 32, expected: false))
			{
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = fixed_point_FXRep_unsigned_long_Accum_EPS.Invoke() << (int)(uint)checked(32 - num4 - 1);
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ulong)(fixed_point_FXRep_unsigned_long_Accum_MAX.Invoke() - num) < (ulong)x, expected: false))
				{
					result = fixed_point_FXRep_unsigned_long_Accum_MAX.Invoke();
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = cpp_enable_if_cpp_is_fixed_point_v_unsigned_long_Accum_unsigned_long_Accum_type_fixed_point_bit_not_unsigned_long_Accum_unsigned_long_Accum.Invoke(fixed_point_FXRep_unsigned_long_Accum_ZERO.Invoke());
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = checked(32 - num4);
					llvm_lifetime_start_p0.Invoke(8L, &y);
					y = ((num3 != 64) ? (num2 << (int)(uint)num3) : fixed_point_FXRep_unsigned_long_Accum_ZERO.Invoke());
					result = cpp_enable_if_cpp_is_fixed_point_v_unsigned_long_Accum_unsigned_long_Accum_type_fixed_point_bit_and_unsigned_long_Accum_unsigned_long_Accum_unsigned_long_Accum.Invoke(x + num, y);
					llvm_lifetime_end_p0.Invoke(8L, &y);
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					llvm_lifetime_end_p0.Invoke(8L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			return result;
		}
	}
}
