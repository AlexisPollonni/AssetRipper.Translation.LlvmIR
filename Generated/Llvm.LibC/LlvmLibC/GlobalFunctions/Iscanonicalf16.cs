using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Iscanonicalf16
{
	[MangledName("iscanonicalf16")]
	[DemangledName("iscanonicalf16")]
	public unsafe static int Invoke([MangledName("x")] Half X)
	{
		Half half = default(Half);
		Half half2 = X;
		Llvm_lifetime_start_p0.Invoke(2L, &half);
		half = default(Half);
		bool result = Fputil_canonicalize_Float16_0.Invoke(&half, &half2) == 0;
		Llvm_lifetime_end_p0.Invoke(2L, &half);
		return result ? 1 : 0;
	}
}
