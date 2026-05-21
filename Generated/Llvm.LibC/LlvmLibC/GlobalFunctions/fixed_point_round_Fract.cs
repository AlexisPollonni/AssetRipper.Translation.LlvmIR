using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_round_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5roundIDRiEET_S2_i")]
	[DemangledName("_Fract __llvm_libc_20_1_2_::fixed_point::round<_Fract>(_Fract, int)")]
	[return: NativeType("_Fract")]
	public unsafe static short Invoke([NativeType("_Fract")] short x, [NativeType("int")] int n)
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
			if (details_expects_bool_condition_bool.Invoke(num5 >= 15, expected: false))
			{
				result = num4;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(2L, &num);
				num = (short)(FXRep_Fract_EPS.Invoke() << (int)(short)checked(15 - num5 - 1));
				if (details_expects_bool_condition_bool.Invoke(FXRep_Fract_MAX.Invoke() - num < num4, expected: false))
				{
					result = FXRep_Fract_MAX.Invoke();
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &num2);
					num2 = fixed_point_bit_not_Fract.Invoke(FXRep_Fract_ZERO.Invoke());
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = checked(15 - num5);
					llvm_lifetime_start_p0.Invoke(2L, &y);
					y = (short)((num3 != 16) ? (num2 << (int)(short)num3) : FXRep_Fract_ZERO.Invoke());
					result = fixed_point_bit_and_Fract.Invoke((short)(num4 + num), y);
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
