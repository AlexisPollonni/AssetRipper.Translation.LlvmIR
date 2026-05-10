using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class iscanonicalf128
{
	public unsafe static int Invoke(double x)
	{
		double num = 0.0;
		double num2 = x;
		llvm_lifetime_start_p0.Invoke(16L, &num);
		num = double.NaN;
		bool result = int_fputil_canonicalize_float128_0_float128_float128_const.Invoke(&num, &num2) == 0;
		llvm_lifetime_end_p0.Invoke(16L, &num);
		return result ? 1 : 0;
	}
}
