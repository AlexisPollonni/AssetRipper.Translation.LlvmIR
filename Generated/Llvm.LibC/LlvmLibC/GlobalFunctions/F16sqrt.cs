using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16sqrt
{
	[MangledName("f16sqrt")]
	[DemangledName("f16sqrt")]
	public static Half Invoke([MangledName("x")] double X)
	{
		return Fputil_sqrt_Float16_double.Invoke(X);
	}
}
