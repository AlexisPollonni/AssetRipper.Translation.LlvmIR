using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16sqrtl
{
	[MangledName("f16sqrtl")]
	[DemangledName("f16sqrtl")]
	public static Half Invoke([MangledName("x")] double X)
	{
		return Fputil_sqrt_Float16_long_double.Invoke(X);
	}
}
