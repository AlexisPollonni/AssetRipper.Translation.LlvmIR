using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Remainderf
{
	[MangledName("remainderf")]
	[DemangledName("remainderf")]
	public unsafe static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		float result = Fputil_remquo_float_0.Invoke(X, Y, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
