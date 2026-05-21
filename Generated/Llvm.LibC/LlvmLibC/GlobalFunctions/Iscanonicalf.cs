using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Iscanonicalf
{
	[MangledName("iscanonicalf")]
	[DemangledName("iscanonicalf")]
	public unsafe static int Invoke([MangledName("x")] float X)
	{
		float num = 0f;
		float num2 = X;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = float.NaN;
		bool result = Fputil_canonicalize_float_0.Invoke(&num, &num2) == 0;
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result ? 1 : 0;
	}
}
