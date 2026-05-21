using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_round_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5roundIDAiEET_S2_i")]
	[DemangledName("_Accum __llvm_libc_20_1_2_::fixed_point::round<_Accum>(_Accum, int)")]
	[return: NativeType("_Accum")]
	public unsafe static int Invoke([NativeType("_Accum")] int x, [NativeType("int")] int n)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int y = 0;
		int num4 = n;
		if (details_expects_bool_condition_bool.Invoke(num4 < 0, expected: false))
		{
			num4 = 0;
		}
		int result;
		if (details_expects_bool_condition_bool.Invoke(num4 >= 15, expected: false))
		{
			result = x;
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FXRep_Accum_EPS.Invoke() << 15 - num4 - 1;
			if (details_expects_bool_condition_bool.Invoke(unchecked(FXRep_Accum_MAX.Invoke() - num) < x, expected: false))
			{
				result = FXRep_Accum_MAX.Invoke();
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = fixed_point_bit_not_Accum.Invoke(FXRep_Accum_ZERO.Invoke());
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = 15 - num4;
				llvm_lifetime_start_p0.Invoke(4L, &y);
				y = ((num3 != 32) ? (num2 << num3) : FXRep_Accum_ZERO.Invoke());
				result = fixed_point_bit_and_Accum.Invoke(unchecked(x + num), y);
				llvm_lifetime_end_p0.Invoke(4L, &y);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return result;
	}
}
