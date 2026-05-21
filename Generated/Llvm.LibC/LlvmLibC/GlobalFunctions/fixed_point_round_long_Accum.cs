using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_round_long_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5roundIDAlEET_S2_i")]
	[DemangledName("long _Accum __llvm_libc_20_1_2_::fixed_point::round<long _Accum>(long _Accum, int)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([NativeType("long _Accum")] long x, [NativeType("int")] int n)
	{
		long num = 0L;
		long num2 = 0L;
		int num3 = 0;
		long y = 0L;
		int num4 = n;
		if (details_expects_bool_condition_bool.Invoke(num4 < 0, expected: false))
		{
			num4 = 0;
		}
		unchecked
		{
			long result;
			if (details_expects_bool_condition_bool.Invoke(num4 >= 31, expected: false))
			{
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = FXRep_long_Accum_EPS.Invoke() << (int)(uint)checked(31 - num4 - 1);
				if (details_expects_bool_condition_bool.Invoke(FXRep_long_Accum_MAX.Invoke() - num < x, expected: false))
				{
					result = FXRep_long_Accum_MAX.Invoke();
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = fixed_point_bit_not_long_Accum.Invoke(FXRep_long_Accum_ZERO.Invoke());
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = checked(31 - num4);
					llvm_lifetime_start_p0.Invoke(8L, &y);
					y = ((num3 != 64) ? (num2 << (int)(uint)num3) : FXRep_long_Accum_ZERO.Invoke());
					result = fixed_point_bit_and_long_Accum.Invoke(x + num, y);
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
