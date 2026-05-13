using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5roundIDAjEET_S2_i")]
[DemangledName("unsigned _Accum __llvm_libc_20_1_2_::fixed_point::round<unsigned _Accum>(unsigned _Accum, int)")]
internal static partial class unsigned_Accum_fixed_point_round_unsigned_Accum_unsigned_Accum_int
{
	public unsafe static int Invoke(int x, int n)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int y = 0;
		int num4 = n;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num4 < 0, expected: false))
		{
			num4 = 0;
		}
		int result;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num4 >= 16, expected: false))
		{
			result = x;
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fixed_point_FXRep_unsigned_Accum_EPS.Invoke() << 16 - num4 - 1;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(unchecked((uint)(fixed_point_FXRep_unsigned_Accum_MAX.Invoke() - num) < (uint)x), expected: false))
			{
				result = fixed_point_FXRep_unsigned_Accum_MAX.Invoke();
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = cpp_enable_if_cpp_is_fixed_point_v_unsigned_Accum_unsigned_Accum_type_fixed_point_bit_not_unsigned_Accum_unsigned_Accum.Invoke(fixed_point_FXRep_unsigned_Accum_ZERO.Invoke());
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = 16 - num4;
				llvm_lifetime_start_p0.Invoke(4L, &y);
				y = ((num3 != 32) ? (num2 << num3) : fixed_point_FXRep_unsigned_Accum_ZERO.Invoke());
				result = cpp_enable_if_cpp_is_fixed_point_v_unsigned_Accum_unsigned_Accum_type_fixed_point_bit_and_unsigned_Accum_unsigned_Accum_unsigned_Accum.Invoke(unchecked(x + num), y);
				llvm_lifetime_end_p0.Invoke(4L, &y);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return result;
	}
}
