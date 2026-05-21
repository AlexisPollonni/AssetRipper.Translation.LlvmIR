using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_round_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5roundIDAiEET_S2_i")]
	[DemangledName("_Accum __llvm_libc_20_1_2_::fixed_point::round<_Accum>(_Accum, int)")]
	[return: NativeType("_Accum")]
	public unsafe static int Invoke([MangledName("x")][NativeType("_Accum")] int X, [MangledName("n")][NativeType("int")] int N)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int y = 0;
		int num4 = N;
		if (Details_expects_bool_condition_bool.Invoke(num4 < 0, Expected: false))
		{
			num4 = 0;
		}
		int result;
		if (Details_expects_bool_condition_bool.Invoke(num4 >= 15, Expected: false))
		{
			result = X;
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FXRep_Accum_EPS.Invoke() << 15 - num4 - 1;
			if (Details_expects_bool_condition_bool.Invoke(unchecked(FXRep_Accum_MAX.Invoke() - num) < X, Expected: false))
			{
				result = FXRep_Accum_MAX.Invoke();
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = Fixed_point_bit_not_Accum.Invoke(FXRep_Accum_ZERO.Invoke());
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = 15 - num4;
				Llvm_lifetime_start_p0.Invoke(4L, &y);
				y = ((num3 != 32) ? (num2 << num3) : FXRep_Accum_ZERO.Invoke());
				result = Fixed_point_bit_and_Accum.Invoke(unchecked(X + num), y);
				Llvm_lifetime_end_p0.Invoke(4L, &y);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return result;
	}
}
