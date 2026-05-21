using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scalbnf16
{
	[MangledName("scalbnf16")]
	[DemangledName("scalbnf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("n")] int N)
	{
		return Fputil_ldexp_Float16_int.Invoke(X, N);
	}
}
