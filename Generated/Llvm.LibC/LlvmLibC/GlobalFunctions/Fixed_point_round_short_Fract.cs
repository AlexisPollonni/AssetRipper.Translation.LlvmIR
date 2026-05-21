using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_round_short_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5roundIDRsEET_S2_i")]
	[DemangledName("short _Fract __llvm_libc_20_1_2_::fixed_point::round<short _Fract>(short _Fract, int)")]
	[return: NativeType("short")]
	public unsafe static sbyte Invoke([MangledName("x")][NativeType("short _Fract")] sbyte X, [MangledName("n")][NativeType("int")] int N)
	{
		sbyte b = 0;
		sbyte b2 = 0;
		int num = 0;
		sbyte y = 0;
		sbyte b3 = X;
		int num2 = N;
		if (Details_expects_bool_condition_bool.Invoke(num2 < 0, Expected: false))
		{
			num2 = 0;
		}
		unchecked
		{
			sbyte result;
			if (Details_expects_bool_condition_bool.Invoke(num2 >= 7, Expected: false))
			{
				result = b3;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (sbyte)(FXRep_short_Fract_EPS.Invoke() << (int)(sbyte)checked(7 - num2 - 1));
				if (Details_expects_bool_condition_bool.Invoke(FXRep_short_Fract_MAX.Invoke() - b < b3, Expected: false))
				{
					result = FXRep_short_Fract_MAX.Invoke();
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(1L, &b2);
					b2 = Fixed_point_bit_not_short_Fract.Invoke(FXRep_short_Fract_ZERO.Invoke());
					Llvm_lifetime_start_p0.Invoke(4L, &num);
					num = checked(7 - num2);
					Llvm_lifetime_start_p0.Invoke(1L, &y);
					y = (sbyte)((num != 8) ? (b2 << (int)(sbyte)num) : FXRep_short_Fract_ZERO.Invoke());
					result = Fixed_point_bit_and_short_Fract.Invoke((sbyte)(b3 + b), y);
					Llvm_lifetime_end_p0.Invoke(1L, &y);
					Llvm_lifetime_end_p0.Invoke(4L, &num);
					Llvm_lifetime_end_p0.Invoke(1L, &b2);
				}
				Llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			return result;
		}
	}
}
