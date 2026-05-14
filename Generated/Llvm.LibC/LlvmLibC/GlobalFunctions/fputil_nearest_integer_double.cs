using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil15nearest_integerEd")]
[DemangledName("__llvm_libc_20_1_2_::fputil::nearest_integer(double)")]
internal static partial class fputil_nearest_integer_double
{
	public unsafe static double Invoke(double x)
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
			result = ((!bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 > 0.5, expected: false)) ? ((!bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 < -0.5, expected: false)) ? num : (num - 1.0)) : (num + 1.0));
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
		else
		{
			result = x;
		}
		return result;
	}
}
