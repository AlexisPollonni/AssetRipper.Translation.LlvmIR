using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_round_short_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5roundIDAsEET_S2_i")]
	[DemangledName("short _Accum __llvm_libc_20_1_2_::fixed_point::round<short _Accum>(short _Accum, int)")]
	[return: NativeType("short")]
	public unsafe static short Invoke([NativeType("short _Accum")] short x, [NativeType("int")] int n)
	{
		short num = 0;
		short num2 = 0;
		int num3 = 0;
		short y = 0;
		short num4 = x;
		int num5 = n;
		if (details_expects_bool_condition_bool.Invoke(num5 < 0, expected: false))
		{
			num5 = 0;
		}
		unchecked
		{
			short result;
			if (details_expects_bool_condition_bool.Invoke(num5 >= 7, expected: false))
			{
				result = num4;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(2L, &num);
				num = (short)(FXRep_short_Accum_EPS.Invoke() << (int)(short)checked(7 - num5 - 1));
				if (details_expects_bool_condition_bool.Invoke(FXRep_short_Accum_MAX.Invoke() - num < num4, expected: false))
				{
					result = FXRep_short_Accum_MAX.Invoke();
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &num2);
					num2 = fixed_point_bit_not_short_Accum.Invoke(FXRep_short_Accum_ZERO.Invoke());
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = checked(7 - num5);
					llvm_lifetime_start_p0.Invoke(2L, &y);
					y = (short)((num3 != 16) ? (num2 << (int)(short)num3) : FXRep_short_Accum_ZERO.Invoke());
					result = fixed_point_bit_and_short_Accum.Invoke((short)(num4 + num), y);
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
