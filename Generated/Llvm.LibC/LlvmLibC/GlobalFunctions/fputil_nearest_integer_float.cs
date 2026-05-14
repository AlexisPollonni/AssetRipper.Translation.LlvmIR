using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil15nearest_integerEf")]
[DemangledName("__llvm_libc_20_1_2_::fputil::nearest_integer(float)")]
internal static partial class fputil_nearest_integer_float
{
	public unsafe static float Invoke(float x)
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
			result = ((!bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 > 0.5f, expected: false)) ? ((!bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 < -0.5f, expected: false)) ? num : (num - 1f)) : (num + 1f));
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
