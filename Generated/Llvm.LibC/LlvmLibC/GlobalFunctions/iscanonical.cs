using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class iscanonical
{
	public unsafe static int Invoke(double x)
	{
		double num = 0.0;
		double num2 = x;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = double.NaN;
		bool result = int_fputil_canonicalize_double_0_double_double_const.Invoke(&num, &num2) == 0;
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result ? 1 : 0;
	}
}
