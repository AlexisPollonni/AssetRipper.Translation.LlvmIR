using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_nearest_integer
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil15nearest_integerEd")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::nearest_integer(double)")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X)
	{
		double num = 0.0;
		double num2 = 0.0;
		double result;
		if (X < 9007199254740992.0 && X > -9007199254740992.0)
		{
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = ((!(X < 0.0)) ? (X + 4503599627370496.0 - 4503599627370496.0) : (X - 4503599627370496.0 + 4503599627370496.0));
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = X - num;
			result = ((!Details_expects_bool_condition_bool.Invoke(num2 > 0.5, Expected: false)) ? ((!Details_expects_bool_condition_bool.Invoke(num2 < -0.5, Expected: false)) ? num : (num - 1.0)) : (num + 1.0));
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
		else
		{
			result = X;
		}
		return result;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil15nearest_integerEf")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::nearest_integer(float)")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X)
	{
		float num = 0f;
		float num2 = 0f;
		float result;
		if (X < 16777216f && X > -16777216f)
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = ((!(X < 0f)) ? (X + 8388608f - 8388608f) : (X - 8388608f + 8388608f));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = X - num;
			result = ((!Details_expects_bool_condition_bool.Invoke(num2 > 0.5f, Expected: false)) ? ((!Details_expects_bool_condition_bool.Invoke(num2 < -0.5f, Expected: false)) ? num : (num - 1f)) : (num + 1f));
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		else
		{
			result = X;
		}
		return result;
	}
}
