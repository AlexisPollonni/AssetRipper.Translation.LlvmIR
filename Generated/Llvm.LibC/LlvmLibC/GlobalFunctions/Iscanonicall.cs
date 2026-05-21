using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Iscanonicall
{
	[MangledName("iscanonicall")]
	[DemangledName("iscanonicall")]
	public unsafe static int Invoke([MangledName("x")] double X)
	{
		double num = 0.0;
		double num2 = X;
		Llvm_lifetime_start_p0.Invoke(16L, &num);
		num = double.NaN;
		bool result = Fputil_canonicalize_long_double_0.Invoke(&num, &num2) == 0;
		Llvm_lifetime_end_p0.Invoke(16L, &num);
		return result ? 1 : 0;
	}
}
