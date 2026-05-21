using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_nearest_integer
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil15nearest_integerEd")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::nearest_integer(double)")]
	public unsafe static double Invoke([NativeType("double")] double x)
	{
		double num = 0.0;
		double num2 = 0.0;
		double result;
		if (x < 9007199254740992.0 && x > -9007199254740992.0)
		{
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = ((!(x < 0.0)) ? (x + 4503599627370496.0 - 4503599627370496.0) : (x - 4503599627370496.0 + 4503599627370496.0));
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = x - num;
			result = ((!details_expects_bool_condition_bool.Invoke(num2 > 0.5, expected: false)) ? ((!details_expects_bool_condition_bool.Invoke(num2 < -0.5, expected: false)) ? num : (num - 1.0)) : (num + 1.0));
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
		else
		{
			result = x;
		}
		return result;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil15nearest_integerEf")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::nearest_integer(float)")]
	public unsafe static float Invoke([NativeType("float")] float x)
	{
		float num = 0f;
		float num2 = 0f;
		float result;
		if (x < 16777216f && x > -16777216f)
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = ((!(x < 0f)) ? (x + 8388608f - 8388608f) : (x - 8388608f + 8388608f));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = x - num;
			result = ((!details_expects_bool_condition_bool.Invoke(num2 > 0.5f, expected: false)) ? ((!details_expects_bool_condition_bool.Invoke(num2 < -0.5f, expected: false)) ? num : (num - 1f)) : (num + 1f));
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		else
		{
			result = x;
		}
		return result;
	}
}
