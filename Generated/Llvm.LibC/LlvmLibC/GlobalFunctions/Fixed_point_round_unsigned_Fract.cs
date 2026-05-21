using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_round_unsigned_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5roundIDRjEET_S2_i")]
	[DemangledName("unsigned _Fract __llvm_libc_20_1_2_::fixed_point::round<unsigned _Fract>(unsigned _Fract, int)")]
	[return: NativeType("unsigned _Fract")]
	public unsafe static short Invoke([MangledName("x")][NativeType("unsigned _Fract")] short X, [MangledName("n")][NativeType("int")] int N)
	{
		short num = 0;
		short num2 = 0;
		int num3 = 0;
		short y = 0;
		short num4 = X;
		int num5 = N;
		if (Details_expects_bool_condition_bool.Invoke(num5 < 0, Expected: false))
		{
			num5 = 0;
		}
		unchecked
		{
			short result;
			if (Details_expects_bool_condition_bool.Invoke(num5 >= 16, Expected: false))
			{
				result = num4;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(2L, &num);
				num = (short)(FXRep_unsigned_Fract_EPS.Invoke() << (int)(short)checked(16 - num5 - 1));
				if (Details_expects_bool_condition_bool.Invoke((uint)(FXRep_unsigned_Fract_MAX.Invoke() - num) < (uint)num4, Expected: false))
				{
					result = FXRep_unsigned_Fract_MAX.Invoke();
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &num2);
					num2 = Fixed_point_bit_not_unsigned_Fract.Invoke(FXRep_unsigned_Fract_ZERO.Invoke());
					Llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = checked(16 - num5);
					Llvm_lifetime_start_p0.Invoke(2L, &y);
					y = (short)((num3 != 16) ? (num2 << (int)(short)num3) : FXRep_unsigned_Fract_ZERO.Invoke());
					result = Fixed_point_bit_and_unsigned_Fract.Invoke((short)(num4 + num), y);
					Llvm_lifetime_end_p0.Invoke(2L, &y);
					Llvm_lifetime_end_p0.Invoke(4L, &num3);
					Llvm_lifetime_end_p0.Invoke(2L, &num2);
				}
				Llvm_lifetime_end_p0.Invoke(2L, &num);
			}
			return result;
		}
	}
}
