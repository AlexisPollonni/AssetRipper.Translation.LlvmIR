using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Remainderl
{
	[MangledName("remainderl")]
	[DemangledName("remainderl")]
	public unsafe static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		double result = Fputil_remquo_long_double_0.Invoke(X, Y, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
