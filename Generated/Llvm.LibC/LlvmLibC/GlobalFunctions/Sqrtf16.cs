using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sqrtf16
{
	[MangledName("sqrtf16")]
	[DemangledName("sqrtf16")]
	public static Half Invoke([MangledName("x")] Half X)
	{
		return Fputil_sqrt_Float16_Float16.Invoke(X);
	}
}
