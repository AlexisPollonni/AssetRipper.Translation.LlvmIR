using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Remainderf128
{
	[MangledName("remainderf128")]
	[DemangledName("remainderf128")]
	public unsafe static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		double result = Fputil_remquo_float128_0.Invoke(X, Y, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
