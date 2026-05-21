using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ldexpf16
{
	[MangledName("ldexpf16")]
	[DemangledName("ldexpf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("exp")] int Exp)
	{
		return Fputil_ldexp_Float16_int.Invoke(X, Exp);
	}
}
