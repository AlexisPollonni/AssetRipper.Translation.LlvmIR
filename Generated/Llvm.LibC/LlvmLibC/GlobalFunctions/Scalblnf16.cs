using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scalblnf16
{
	[MangledName("scalblnf16")]
	[DemangledName("scalblnf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("n")] long N)
	{
		return Fputil_ldexp_Float16_long.Invoke(X, N);
	}
}
