using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Remainderf16
{
	[MangledName("remainderf16")]
	[DemangledName("remainderf16")]
	public unsafe static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		Half result = Fputil_remquo_Float16_0.Invoke(X, Y, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
