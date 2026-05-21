using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16sqrtf
{
	[MangledName("f16sqrtf")]
	[DemangledName("f16sqrtf")]
	public static Half Invoke([MangledName("x")] float X)
	{
		return Fputil_sqrt_Float16_float.Invoke(X);
	}
}
