using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Isnanf
{
	[MangledName("isnanf")]
	[DemangledName("isnanf")]
	public static int Invoke([MangledName("x")] float X)
	{
		return Llvm_is_fpclass_f32.Invoke(X, 3) ? 1 : 0;
	}
}
